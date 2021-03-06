﻿namespace Scripts.Core.Config
{
    //Usually, this class is used for persistent configuration data, but for this
    //project I also use it to store camera dimensions
    public partial class GameConfig
	{
        public int CameraWidth, CameraHeight;

        public const float CameraDistance = 10f;

        public const float ColorSampleAwaitTime = 1f;

		private static GameConfig _currentConfig;

		public static GameConfig GetConfig
        {
            get
            {
                if (_currentConfig == null)
                {
                    _currentConfig = new GameConfig();
                }
                return _currentConfig;
            }
        }
	}
}