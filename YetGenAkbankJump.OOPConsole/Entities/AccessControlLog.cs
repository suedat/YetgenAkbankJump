using System;
using YetGenAkbankJump.OOPConsole.Common;
using YetGenAkbankJump.OOPConsole.Enums;

namespace YetGenAkbankJump.OOPConsole.Entities
{
	public class AccessControlLog:EntityBase<>
	{
	
		public long PersonId { get; set; }
		public string DeviceSerialNo { get; set; }
		public object MyProperty { get; set; }
		public AccessType AcessType { get; set; }
		public DateTime LogTime { get; set; }

		public static AccessType ConvertStringToAccessType(string accessType)
		{
			switch (accessType)
			{
				case "FP":
					return AccessType.FingerPrint;
				case "FACE":
					return AccessType.Face;
				case "CARD":
					return AccessType.Card;
				default:
					throw new Exception(message: "");
			}
		}
	}
}

