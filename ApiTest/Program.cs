﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BtcE;

namespace ApiTest
{
	class Program
	{
		static void Main(string[] args) {
            //var depth3 = BtceApiV3.GetDepth(new[] { BtcePair.BTCUSD });
            //var ticker3 = BtceApiV3.GetTicker(new[] { BtcePair.BTCUSD });
            //var trades3 = BtceApiV3.GetTrades(new[] { BtcePair.BTCUSD });
            var ticker = BtceApi.GetTicker(BtcePair.btc_usd);
            //var trades = BtceApi.GetTrades(BtcePair.BTCUSD);
            //var btcusdDepth = BtceApi.GetDepth(BtcePair.BTCUSD);
            //var fee = BtceApi.GetFee(BtcePair.BTCUSD);

            //var btceApi = new BtceApi("API_KEY", "API_SECRET");
            //var info = btceApi.GetInfo();
            //var transHistory = btceApi.GetTransHistory();
            //var tradeHistory = btceApi.GetTradeHistory(count: 20);
            //var orderList = btceApi.GetOrderList();
            //var tradeAnswer = btceApi.Trade(BtcePair.BTCUSD, TradeType.Sell, 20, 0.1m);
            //var cancelAnswer = btceApi.CancelOrder(tradeAnswer.OrderId);
		}
	}
}
