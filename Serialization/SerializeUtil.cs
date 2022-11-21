using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class SerializeUtil
    {
        /// <summary>
        /// 对象序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] Encode(object value)
        {
            //创建编码解码的内存流对象
            MemoryStream ms = new MemoryStream();
            //二进制流序列化对象
            BinaryFormatter bw = new BinaryFormatter();
            //将obj对象序列化成二进制数据写入到内存流
            bw.Serialize(ms, value);
            byte[] result = new byte[ms.Length];
            //将流数据拷贝到结果数组
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            ms.Close();
            return result;
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Decode(byte[] value)
        {
            //创建编码解码的内存流对象 并将需要反序列化的数据写入其中
            MemoryStream ms = new MemoryStream(value);
            //二进制流序列化对象
            BinaryFormatter bw = new BinaryFormatter();
            //将流数据反序列化为obj对象
            object result = bw.Deserialize(ms);
            ms.Close();
            return result;
        }
    }
}