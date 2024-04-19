using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URProject.Classes {
    public class ClassRTDE {

        FormMain mainForm;

        public ClassRTDE(FormMain mainForm) {
            this.mainForm = mainForm;
            Logging.LogInformation(1, "ClassRTDE - Initialization Completed");
        }

    }
}
