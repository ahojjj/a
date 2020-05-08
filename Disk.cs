using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace noty
{
    public class Disk
    {
        public string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public bool[] errorlevl = new bool[6] { true, true, true, true, true, true };
        public void WriteFile(string text,string Cesta)
        {
            using (StreamWriter writer = new StreamWriter(Cesta))
            {
                writer.Write(text);
            }
            errorlevl[0] = true;
        }
        public string ReadFile(string Cesta)
        {
            string read;
            if (File.Exists(Cesta))
            {
                using (StreamReader reader = new StreamReader(Cesta))
                {
                    read = reader.ReadToEnd();
                }
                errorlevl[0] = true;
            }
            else
            {
                errorlevl[0] = false;
                read = "Chyba v Ceste";
            }
            return read;
        }
        public string[] DirFile(string Cesta,string Filter="*",int Options = 1,char fileDirectory = 'f')
        {
            SearchOption option;
            if (Options==1)
            {
                option = SearchOption.AllDirectories;
            }
            else
            {
                option = SearchOption.TopDirectoryOnly;
            }
            if (Directory.Exists(Cesta))
            {
                errorlevl[2] = true;
                switch (fileDirectory)
                {
                    case 'f':
                        return Directory.GetFiles(Cesta, Filter, option);
                    case 'd':
                        return Directory.GetDirectories(Cesta, Filter, option);
                    default:
                        string[] errorrr = new string[1] { "" };
                        return errorrr;
                }
            }
            else
            {
                string[] errorrr = new string[1] { ""};
                errorlevl[2]=false;
                return errorrr;
            }
        }
        public string[] DirFile(string Cesta, char fileDirectory = 'd')
        {
            return DirFile(Cesta,"*",1,fileDirectory);
        }
        public void Del(string Name,string FD = "f")
        {
            FD = FD.ToLower();
            if (FD == "f")
            {
                if (File.Exists(Name))
                {
                    errorlevl[3] = true;
                    File.Delete(Name);
                }
                else
                {
                    errorlevl[3] = false;
                }
            }
            else
            {
                if (Directory.Exists(Name))
                {
                    errorlevl[3] = true;
                    Directory.Delete(Name,true);
                }
                else
                {
                    errorlevl[3] = false;
                }
            }
        }
        public void CreatDirectory(string Cesta)
        {
            if (!Directory.Exists(Cesta))
            {
                try
                {
                    Directory.CreateDirectory(Cesta);
                    errorlevl[4] = true;
                }
                catch
                {
                    errorlevl[4] = false;
                }
            }
            else
            {
                errorlevl[4] = false;
            }
        }
        public void CopyFile(string Name1,string Name2)
        {
            if (File.Exists(Name1))
            {
                errorlevl[3] = true;
                File.Copy(Name1, Name2);
            }
            else
            {
                errorlevl[3] = false;
            }
        }

        public bool exist(string Cesta,string FileDirectoryes="F")
        {
            FileDirectoryes = FileDirectoryes.ToLower();
            if (FileDirectoryes=="f")
            {
                return File.Exists(Cesta);
            }
            else
            {
                return Directory.Exists(Cesta);
            }
        }
    }
}
