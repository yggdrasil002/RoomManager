using System;
using System.Linq;
using System.Net.Mail;
using MySql.Data.MySqlClient;


namespace ServerBookingRoom
{
    public class ForgotPassword
    {
        public string ForgotPasswordStaff(string username, string email, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Staff WHERE Username = @Username AND Email = @Email", conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (count > 0)
                    {
                        string newPassword = GeneratePassword();
                        string resetResult = SendEmail(username, email, newPassword, connectionString);
                        return resetResult;
                    }
                    else
                    {
                        return "Username or email not found.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }

        private string SendEmail(string username, string email, string newPassword, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Staff SET Password=@Password WHERE Username=@Username", conn);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("huyquah03@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Password Reset";
                        mail.Body = $"Your password has been reset. Your new password is: {newPassword}";

                        smtpServer.Port = 587;
                        smtpServer.Credentials = new System.Net.NetworkCredential("huyquah03@gmail.com", "xykf aikf lusa zixg");
                        smtpServer.EnableSsl = true;

                        smtpServer.Send(mail);

                        return "Password reset successfully!";
                    }
                    else
                    {
                        return "Username not found.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }
        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rand = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}