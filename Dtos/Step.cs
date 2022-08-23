using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealState.Dtos
{
    public class Step
    {
        public string fact { get; set; }
        public int length { get; set; }
    }
}
