using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLVT;

namespace BLL_QLVT
{
    public class BUSChatbot
    {
        public static DataTable LastResult = null;

        public static string HandleMessage(string input)
        {
            input = input.ToLower();

            if (input.Contains("vật tư còn hàng"))
            {
                LastResult = DALChat.GetVatTuConHang();
                return "Dưới đây là danh sách vật tư còn hàng:";
            }

            if (input.Contains("chào") || input.Contains("hello"))
                return "Chào bạn! Mình có thể giúp gì?";

            return "Mình chưa hiểu câu hỏi của bạn.";
        }
    }
}
