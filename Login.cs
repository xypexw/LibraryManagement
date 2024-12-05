using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CodeX
{
    public partial class Login : KryptonForm
    {
        private readonly DataClasses1DataContext _dbContext = new DataClasses1DataContext();

        public Login()
        {
            InitializeComponent();
        }

        // Hàm mã hóa SHA256
        private static string ComputeSha256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hash;
            }
        }

        // Kiểm tra mật khẩu
        private static bool VerifyPassword(string inputPassword, string salt, string hashedPassword)
        {
            var hashToCheck = ComputeSha256Hash(inputPassword + salt);
            return hashToCheck == hashedPassword;
        }

        // Xử lý đăng nhập
        private void HandleLogin()
        {
            var username = UserNameTB.Text.Trim();
            var password = PasswordTB.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VerifyPassword(password, user.Salt, user.HashPassword))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tiếp tục xử lý sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện nhấn nút đăng nhập
        private void LoginBT_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }
        // Sự kiện mở form đăng ký
        private void SiginUp_click(object sender, EventArgs e)
        {
            var signupForm = new signup();
            signupForm.Show();
            Hide();
        }
    }
}
