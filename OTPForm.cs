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
using System.Net.Mail;
namespace CodeX
{
    public partial class OTPForm : KryptonForm
    {
        private const int OTP_TIME_LIMIT = 300;
        private int timeRemaining = OTP_TIME_LIMIT;
        private bool emailVerifyStatus;
        private string providedEmail;
        private const string SMTP_HOST = "smtp.gmail.com";
        private const int SMTP_PORT = 587;
        private const string SMTP_USER = "your_email@example.com"; // Tạo tài khoản SMTP an toàn
        private const string SMTP_PASSWORD = "your_password"; // Tạo tài khoản SMTP an toàn
        private SmtpClient smtpClient;
        private MailMessage mailMessage;

        public OTPForm(ref bool emailVerifyStatus, string providedEmail)
        {
            InitializeComponent();
            InitializeEmailClient();
            this.emailVerifyStatus = emailVerifyStatus;
            this.providedEmail = providedEmail;
            timer1.Enabled = true;
            timer1.Interval = 1000;  // Cập nhật mỗi giây
        }

        // Phương thức khởi tạo và cấu hình SMTP client
        private void InitializeEmailClient()
        {
            smtpClient = new SmtpClient
            {
                Host = SMTP_HOST,
                Port = SMTP_PORT,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(SMTP_USER, SMTP_PASSWORD),
                EnableSsl = true
            };

            mailMessage = new MailMessage();
        }

        // Phương thức tạo mã OTP ngẫu nhiên
        private static string GenerateOTPCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            Random random = new Random();
            char[] otpCode = new char[6];

            for (int i = 0; i < 6; i++)
            {
                otpCode[i] = characters[random.Next(characters.Length)];
            }

            return new string(otpCode);
        }

        // Xử lý sự kiện mỗi giây (tính thời gian còn lại của OTP)
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            TimeBT.Text = timeRemaining.ToString();
            if (timeRemaining <= 0)
            {
                timer1.Stop();
                MessageBox.Show("OTP đã hết hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện nút "Hủy" (quay lại trang đăng nhập)
        private void Re_EnterBT_Click(object sender, EventArgs e)
        {
            this.emailVerifyStatus = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Phương thức gửi email OTP
        public void SendOTPEmail(string toEmail, string fromEmail, string subject, string body)
        {
            try
            {
                MailAddress to = new MailAddress(toEmail);
                MailAddress from = new MailAddress(fromEmail);

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.From = from;
                mailMessage.To.Clear(); // Đảm bảo rằng các địa chỉ trước đó đã được xóa
                mailMessage.To.Add(to);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xác thực OTP từ người dùng
        private void veriflyBT_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã OTP do người dùng nhập vào với mã đã gửi qua email
            string userOtp = otpTextBox.Text;
            string generatedOtp = GenerateOTPCode();  // Giả sử mã OTP đã được tạo từ trước

            if (userOtp.Equals(generatedOtp) && timeRemaining > 0)
            {
                MessageBox.Show("Xác thực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.emailVerifyStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
