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
        public void writeRegisterIOLink(int valor)
        {
            ModbusClient modbusClient = new ModbusClient(ClassData.ipIOlink, ClassData.portIOlink);
            modbusClient.Connect();
            modbusClient.WriteSingleRegister(ClassData.registerIOLink, valor);
        }


    }
}
