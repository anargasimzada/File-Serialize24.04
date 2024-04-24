using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Action_Function_PredicateHW2404.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
       

       

       static void Start()
        {
           DateTime StartDate = DateTime.Now;
            DateTime EndDate = StartDate+ExamDuration;
        }
        
    }
}
