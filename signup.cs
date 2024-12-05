using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Drawing.Text;
using System.Data.Linq;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;

namespace CodeX
{
    public partial class signup : KryptonForm
    {
        private DataClasses1DataContext dbo = new DataClasses1DataContext();
        private const string roleofclient = "client";
        public signup()
        {
            InitializeComponent();
            
        }
        // Hàm Tạo ID người dùng 
        private static string GenerateCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] otpCode = new char[6];

            for (int i = 0; i < 6; i++)
            {
                otpCode[i] = characters[random.Next(characters.Length)];
            }

            return new string(otpCode);
        }
        // hàm kiểm tra accept điều kiện 
        private bool checkingapcept()
        {
            if (AcceptRBT.Checked == true) return false;
            else
            {
                MessageBox.Show("Please Accept Our Condition");
                return true;

            }
        }
        // hàm kiểm tra mật khẩu có trùng 
        private bool checkconfirm()
        {
            if (PasswordTB.Text == ConfirmpasswordTB.Text) return false;
            else
            {
                MessageBox.Show("Please Accept Our Condition");
                return true;
            }
        }

        // tạo mã muối 
        private string createsalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[1024];

            rng.GetBytes(buffer);
            string salt = BitConverter.ToString(buffer);
            return salt;
        }
        // tạo SHA256
        private string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        // tạo hashcode 
        private string createhashcode(string userpassword, string salt)
        {
            string hashcode = sha256(userpassword + salt);
            return hashcode;
        }
        // hàm khởi tạo tài khoản 
        private void SubmitBT_Click(object sender, EventArgs e)
        {
            bool isAccepted = checkingapcept();
            bool isConfirmed = checkconfirm();
            if (isAccepted) return;
            if (isConfirmed) return;
            string saltcode = createsalt();
            string hashcode = createhashcode(PasswordTB.Text, saltcode);
            bool email_verify = true;
            OTPForm otp = new OTPForm(ref email_verify,EmailTB.Text);
            otp.ShowDialog();
            if (!email_verify)
            {
                EmailTB.Text = "";            
                return;
            }
            try
            {
                User x = new User();
                x.UserID = GenerateCode();
                x.Email = EmailTB.Text;
                x.Salt = saltcode;
                x.FullName = FullnameTB.Text;
                x.UserName = UsernameTB.Text;
                x.HashPassword = hashcode;
                x.Role = roleofclient;
                dbo.Users.InsertOnSubmit(x);
                dbo.SubmitChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Add Error " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
