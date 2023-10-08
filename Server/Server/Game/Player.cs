using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
	public class Player
	{
		public PlayerInfo Info { get; set; } = new PlayerInfo() { PosInfo = new PositionInfo() }; // 프로토콜 Struct로 Info 관리
		public GameRoom Room { get; set; }
		public ClientSession Session { get; set; }
	}
}
