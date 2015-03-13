namespace Mobile
{
    public enum BatteryType //Problem 3
    {
        LiIon, NiMH, NiCd, LiFePO4
    };
    public class Battery
    {
        private string gsmBatteryModel;
        private ulong gsmHoursIdle;
        private ulong gsmHoursTalk;
        private BatteryType type;

        public Battery(string batteryModel, ulong hoursIdle)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
        }

        public Battery(string batteryModel, ulong hoursIdle, ulong hoursTalk, BatteryType batType)
            : this(batteryModel, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
            this.Type = batType;
        }
        public string BatteryModel { get; set; }

        public ulong HoursIdle { get; set; }

        public ulong HoursTalk { get; set; }

        public BatteryType Type { get; set; }
    }
}
