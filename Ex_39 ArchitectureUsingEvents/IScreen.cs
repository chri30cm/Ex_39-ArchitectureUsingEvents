using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public interface IScreen
    {
        string Answer { get; set; }
        string Warning { get; set; }
        string TextValue { get; set; }
    }
}
