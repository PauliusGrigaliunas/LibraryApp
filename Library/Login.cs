using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Login
    {

        public bool CheckData(String username, String password, int vartotojas)
        {
            bool exists = false;
            using (LibraryDataEntities1 contex = new LibraryDataEntities1())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Prisijungimo_vardas == username
               && r.Slaptazodis == password && r.Vartotojas == vartotojas);

                if (vartotojass != null)
                {
                    exists = true;
                }

            }
            return exists;
        }


        public void FillData(String username, String password, int vartotojas)
        {
            using (LibraryDataEntities1 contex = new LibraryDataEntities1())
            {
                Vartotojai vartotojass = new Vartotojai()
                {
                    Prisijungimo_vardas = username,
                    Slaptazodis = password,
                    Vartotojas = vartotojas,

                };
                contex.Vartotojais.Add(vartotojass);
                contex.SaveChanges();
            }
        }

        public static int GetID(string username)
        {
            int id;
            using (LibraryDataEntities1 contex = new LibraryDataEntities1())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Prisijungimo_vardas == username);
                    id = (int)vartotojass.Id;
            }
            return id;

        }



    }
}
