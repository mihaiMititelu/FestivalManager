using System;
using System.ComponentModel.DataAnnotations;
using TSP_ASPLayer.WcfService;

namespace TSP_ASPLayer.Models
{
    public class ProxyFestivalModels
    {

        [Required(ErrorMessage = "Required!")]
        public string ProxyName { get; set; }
        [Required(ErrorMessage = "Required!")]
        public DateTime ProxyDateAndTime { get; set; }
        [Required(ErrorMessage = "Required!")]
        public Location ProxyLocation { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string ProxyPerformers { get; set; }
        [Required(ErrorMessage = "Required!")]
        public int ProxyTickets { get; set; }
    }
}