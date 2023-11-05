using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Data
{
	public interface ILoader<Key, Value>
	{
		Dictionary<Key, Value> MakeDict();
	}

	public class DataManager
	{
        // Singleton
        public static Dictionary<int, Data.Stat> StatDict { get; private set; } = new Dictionary<int, Data.Stat>();
		public static Dictionary<int, Data.Skill> SkillDict { get; private set; } = new Dictionary<int, Data.Skill>();

		// JSON 데이터를 Dict로 변환
		public static void LoadData()
		{
			StatDict = LoadJson<Data.StatData, int, Data.Stat>("StatData").MakeDict();
			SkillDict = LoadJson<Data.SkillData, int, Data.Skill>("SkillData").MakeDict();
		}

		// JSON 데이터 로드 후 Dict로 반환
		static Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
		{
			string text = File.ReadAllText($"{ConfigManager.Config.dataPath}/{path}.json");
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Loader>(text);
		}
	}
}
