using System;
using System.Runtime.InteropServices;

namespace URProject.Classes
{
    interface IEncoderDecoder
    {
        object Decode(ref object o, byte[] buf, ref int offset);
        void Encode(object o, byte[] buf, ref int offset);
    }
    class EncodeValue : IEncoderDecoder // For bool, uint, int, ulong, double
    {
        Type type;
        int Typesize;

        public EncodeValue(Type type)
        {
            this.type = type;
            Typesize = Marshal.SizeOf(type);
        }

        public void Encode(object o, byte[] buf, ref int offset)
        {

            byte[] b = null;
            switch (type.FullName)
            {
                case "System.Boolean":
                    b = BitConverter.GetBytes((bool)o);
                    break;
                case "System.Byte":
                    b = new byte[1];
                    b[0] = (byte)o;
                    break;
                case "System.UInt32":
                    b = BitConverter.GetBytes((UInt32)o);
                    break;
                case "System.Int32":
                    b = BitConverter.GetBytes((Int32)o);
                    break;
                case "System.UInt64":
                    b = BitConverter.GetBytes((UInt64)o);
                    break;
                case "System.Double":
                    b = BitConverter.GetBytes((Double)o);
                    break;
            }

            if (BitConverter.IsLittleEndian)
                Array.Reverse(b);
            Array.Copy(b, 0, buf, offset, Typesize);
            offset += Typesize;
        }

        public object Decode(ref object o, byte[] buf, ref int offset)
        {

            // object o not used, value type

            byte[] b = new byte[Typesize];
            Array.Copy(buf, offset, b, 0, Typesize);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(b);
            offset += Typesize;

            switch (type.FullName)
            {
                case "System.Boolean":
                    return BitConverter.ToBoolean(b, 0);
                case "System.Byte":
                    return b[0];
                case "System.UInt32":
                    return BitConverter.ToUInt32(b, 0);
                case "System.Int32":
                    return BitConverter.ToInt32(b, 0);
                case "System.UInt64":
                    return BitConverter.ToUInt64(b, 0);
                case "System.Double":
                    return BitConverter.ToDouble(b, 0);
            }

            return null;
        }
    }
    class EncodeArray : IEncoderDecoder // For uint[], int[], ulong[], double[]
    {
        int ArraySize, Typesize;
        Type type;
        public EncodeArray(int size, Type type)
        {
            ArraySize = size;
            Typesize = Marshal.SizeOf(type);
            this.type = type;
        }

        public void Encode(object o, byte[] buf, ref int offset)
        {
            Array array = o as Array;

            for (int i = 0; i < ArraySize; i++)
            {
                byte[] b = null;

                switch (type.FullName)
                {
                    case "System.UInt32":
                        b = BitConverter.GetBytes((UInt32)array.GetValue(i));
                        break;
                    case "System.Int32":
                        b = BitConverter.GetBytes((Int32)array.GetValue(i));
                        break;
                    case "System.UInt64":
                        b = BitConverter.GetBytes((UInt64)array.GetValue(i));
                        break;
                    case "System.Double":
                        b = BitConverter.GetBytes((Double)array.GetValue(i));
                        break;
                }
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(b);
                Array.Copy(b, 0, buf, offset, Typesize);
                offset += Typesize;
            }
        }
        public object Decode(ref object o, byte[] buf, ref int offset)
        {

            Array obj = o as Array;

            for (int i = 0; i < ArraySize; i++)
            {
                byte[] b = new byte[Typesize];
                Array.Copy(buf, offset, b, 0, Typesize);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(b);
                offset += Typesize;

                object value = null; ;

                switch (type.FullName)
                {
                    case "System.UInt32":
                        value = BitConverter.ToUInt32(b, 0);
                        break;
                    case "System.Int32":
                        value = BitConverter.ToInt32(b, 0);
                        break;
                    case "System.UInt64":
                        value = BitConverter.ToUInt64(b, 0);
                        break;
                    case "System.Double":
                        value = BitConverter.ToDouble(b, 0);
                        break;
                }

                obj.SetValue(value, i);
            }

            return obj; // Not used, type reference
        }
    }
}
