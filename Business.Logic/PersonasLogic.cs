using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Business.Logic
{
    public class PersonasLogic : BusinessLogic
    {
        public PersonasLogic() 
        {
            this.PersonasData = new PersonasAdapter();
        }
        private PersonasAdapter _PersonasData;
        public PersonasAdapter PersonasData
        {
            get { return _PersonasData; }
            set { _PersonasData = value; }
        }
        public List<Personas> GetAll()
        {
            List<Personas> personas = PersonasData.GetAll();
            return personas;
        }
        public Personas GetOne(int ID)
        {
            Personas persona = PersonasData.GetOne(ID);
            return persona;
        }
        public void Save(Personas per)
        {
            PersonasData.Save(per);
        }
        public void Delete(int ID)
        {
            PersonasData.Delete(ID);
        }
        public bool VerificaMail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
