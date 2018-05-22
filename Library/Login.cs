using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Login
    {
        LibraryDataEntities2 entities2 = new LibraryDataEntities2();

        public bool CheckData(string username, string password, int user)
        {
            bool exists = false;
            using (LibraryDataEntities2 contex = new LibraryDataEntities2())
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
            using (LibraryDataEntities2 contex = new LibraryDataEntities2())
            {
                int index = contex.Vartotojais.Count();
                Vartotojai vartotojass = new Vartotojai()
                {
                    Id = user.PhoneNumber,
                    Prisijungimo_vardas = user.Username,
                    Slaptazodis = user.Password,
                    Vartotojas = user.Vartotojas

                };
                contex.Vartotojais.Add(vartotojass);
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
            using (LibraryDataEntities2 contex = new LibraryDataEntities2())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Prisijungimo_vardas == username);
                    id = (int)vartotojass.Id;
            }
            return id;

        }



    }
}
