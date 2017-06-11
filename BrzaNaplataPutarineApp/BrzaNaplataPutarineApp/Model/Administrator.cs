using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrzaNaplataPutarineApp.Model
{
    public class Administrator : INotifyPropertyChanged
    {
        
        private string email;
        private string lozinka;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Lozinka
        {
            get
            {
                return lozinka;
            }
             
            set
            {
                if (value != lozinka)
                {
                    lozinka = value;
                }
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AdministratorId { get; set; }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (value != email)
                {
                    email = value;
                }
            }
        }
    }
}
