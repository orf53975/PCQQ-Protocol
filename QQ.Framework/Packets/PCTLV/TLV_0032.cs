using System;
using QQ.Framework;

namespace QQ.Framework.Packets.PCTLV
{
    internal class TLV_0032 : BaseTLV
    {
        public TLV_0032()
        {
            cmd = 0x0032;
            Name = "TLV_QdData";
            wSubVer = 0x0002;
        }

        public byte[] get_tlv_0032(QQClient m_PCClient)
        {
            //TODO:QdData
            throw new Exception("QdData 获取失败！");

            //byte[] qddata = null;
            //if (m_PCClient.m_LisHelper.GetQdData((uint)m_PCClient.QQUser.QQ, m_PCClient.dwServerIP, m_PCClient.QQUser.TXProtocol.bufComputerIDEx, out qddata))
            //{
            //    fill_head(this.cmd);
            //    fill_body(qddata, qddata.Length);
            //    set_length();
            //    return get_buf();
            //}
            //else
            //{
            //    throw new Exception("QdData 获取失败！");
            //}
        }
    }
}