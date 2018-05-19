using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Login
    {

        public bool CheckData(String username, String password, int user)
        {
            bool exists = false;
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Prisijungimo_vardas == username
               && r.Slaptazodis == password && r.Vartotojas == user);

                if (vartotojass != null)
                {
                    exists = true;
                }

            }
            return exists;
        }


        public void FillData(User user)
        {
            try
            {
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                int index = contex.Vartotojais.Count();
                Vartotojai vartotojas = new Vartotojai()
                {
                    Id = 1,
                    Prisijungimo_vardas = user.Username,
                    Slaptazodis = user.Password,
                    Vartotojas = user.Vartotojas

                };
                contex.Vartotojais.Add(vartotojas);
                contex.SaveChanges();
            }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static int GetID(string username)
        {
            int id;
            using (LibraryDataEntities contex = new LibraryDataEntities())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Prisijungimo_vardas == username);
                    id = (int)vartotojass.Id;
            }
            return id;

        }



    }
}
