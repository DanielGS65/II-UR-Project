using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;


namespace URProject.Classes
{

    public class ClassMODBUS
    {

        public bool IOLinkStatus { 
            get { return this.IOLinkStatus; } set { writeRegisterIOLink(value); } }
        public void writeRegisterIOLink(bool valor)
        {
            int numValor = 0;
            if (valor)
            {
                numValor = 1;
            } 
            ModbusClient modbusClient = new ModbusClient(ClassData.ipIOlink, ClassData.portIOlink);
            modbusClient.Connect();
            modbusClient.WriteSingleRegister(ClassData.registerIOLink, numValor);
        }


    }
}
