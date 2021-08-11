using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    interface IContactBL
    {
        IEnumerable<ContactForm> GetAll();
        void Add(ContactForm contact);
        ContactForm Edit(int id);
        ContactForm Delete(int id);

    }
}
