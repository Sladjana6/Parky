using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Models.Dtos
{
    public class NationalParkDto
    {
        //1. izmena za Git sa dete grane

        //2. izmena za Git sa mastera

        //3. izmena sa mastera
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        public DateTime Created { get; set; }
        public byte[] Picture { get; set; }


        //ovo je 4.izmena sa mastera
        public DateTime Established { get; set; }
    }
}
