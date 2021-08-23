using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomilostitveniPostopek
{
    public static class Users
    {
        public static User ministerstvo_prijavljeni = null;
        public static User Sodišče_prijavljeni = null;
        
        public class User
        {
            private string username { get; set; }
            private string password { get; set; }
            
            public User(string username, string password )
            {
                this.username = username;
                this.password = password;
            }


            /// <summary>
            /// Nastavi uporabnika
            /// </summary>
            /// <param name="tip"></param>
            /// <returns></returns>
            public bool Prijava(AllnOne.Ustanova tip)
            {
                if(tip == AllnOne.Ustanova.Sodišče)
                {
                    Sodišče_prijavljeni = this;
                    return true;
                }

                if (tip == AllnOne.Ustanova.Ministerstvo)
                {
                    ministerstvo_prijavljeni = this;
                    return true;
                }
                return false;
            }
            /// <summary>
            /// Nastavi določenega uporabnika na null
            /// </summary>
            /// <param name="tip"></param>
            /// <returns></returns>
            public bool Odjava(AllnOne.Ustanova tip)
            {
                if (tip == AllnOne.Ustanova.Sodišče)
                {
                    Sodišče_prijavljeni = null;
                    return true;
                }

                if (tip == AllnOne.Ustanova.Ministerstvo)
                {
                    ministerstvo_prijavljeni = null;
                    return true;
                }
                return false;
            }
            /// <summary>
            /// Preveri uporabnika ki se prijavlja
            /// </summary>
            /// <param name="tip"></param>
            /// <returns></returns>
            public bool uporabnikObstaja(AllnOne.Ustanova tip)
            {
                if(tip == AllnOne.Ustanova.Sodišče)
                {
                    if (VsiZaposleni(AllnOne.Ustanova.Sodišče).Exists(t => t.username == this.username && t.password == this.password))
                    { return true; }
                    else { return false; }
                }

                if (tip == AllnOne.Ustanova.Ministerstvo)
                {
                    if (VsiZaposleni(AllnOne.Ustanova.Ministerstvo).Exists(t => t.username == this.username && t.password == this.password))
                    { return true; }
                    else { return false; }
                }

                throw new Exception("This actualy should never happen!!!");
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="tip"></param>
            /// <returns>List zaposlenih za določen tip, če tip ni sodišče ali ministerstvo vrne null</returns>
            private List<User> VsiZaposleni(AllnOne.Ustanova tip)
            {
                List<User> users = new List<User>();
                if (tip == AllnOne.Ustanova.Ministerstvo)
                {

                    users.Add(new User("Ministerstvo1", "Ministerstvo1"));
                    users.Add(new User("Ministerstvo2", "Ministerstvo3"));
                    users.Add(new User("Ministerstvo3", "Ministerstvo4"));
                    users.Add(new User("Ministerstvo4", "Ministerstvo5"));
                    return users;
                }

                if (tip == AllnOne.Ustanova.Sodišče)
                {
                    users.Add(new User("Sodišče1", "Sodišče1"));
                    users.Add(new User("Sodišče2", "Sodišče2"));
                    users.Add(new User("Sodišče3", "Sodišče3"));
                    users.Add(new User("Sodišče4", "Sodišče4"));

                    return users;
                }
                else return null;
            }

        }
    }
}
