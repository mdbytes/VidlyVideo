using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please select membership type")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthday { get; set; }

        public string getMemberShipType(int MembershipTypeID)
        {
            string result;

            switch (MembershipTypeID)
            {
                case 1:
                    result = "Pay as you go";
                    break;

                case 2:
                    result = "Monthly";
                    break;

                case 3:
                    result = "Quarterly";
                    break;


                case 4:
                    result = "Annual";
                    break;

                default:
                    result = "Pay as you go";
                    break;

            }

            return result;
        }

        public string getBirthdayString()
        {
            try
            {
                DateTime dt = (DateTime)this.Birthday;
                return dt.ToString("mm/dd/yyyy");
            
            }catch (Exception)
            {
                return "n/a";
            }
            
        }

        public string getSubsciptionStatusString()
        {
            if(this.IsSubscribedToNewsletter)
            {
                return "Yes";
            } else
            {
                return "No";
            }
        }
        
    }

    

    
    


}