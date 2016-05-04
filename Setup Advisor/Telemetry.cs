using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup_Advisor
{

    public class Telemetry
    {
        public string status { get; set; } = null;
        public Gamestates gameStates { get; set; }
        public Unfilteredinput unfilteredInput { get; set; }
        public Vehicleinformation vehicleInformation { get; set; }
        public Eventinformation eventInformation { get; set; }
        public Timings timings { get; set; }
        public Flags flags { get; set; }
        public Pitinfo pitInfo { get; set; }
        public Carstate carState { get; set; }
        public Motionanddevicerelated motionAndDeviceRelated { get; set; }
        public Wheelsandtyres wheelsAndTyres { get; set; }
        public Cardamage carDamage { get; set; }
        public Weather weather { get; set; }

    }
    
    public class Gamestates
    {
        public int mGameState { get; set; }
        public int mSessionState { get; set; }
        public int mRaceState { get; set; }
    }

    public class Unfilteredinput
    {
        public float mUnfilteredThrottle { get; set; }
        public float mUnfilteredBrake { get; set; }
        public float mUnfilteredSteering { get; set; }
        public float mUnfilteredClutch { get; set; }
    }

    public class Vehicleinformation
    {
        public string mCarName { get; set; }
        public string mCarClassName { get; set; }
    }

    public class Eventinformation
    {
        public int mLapsInEvent { get; set; }
        public string mTrackLocation { get; set; }
        public string mTrackVariation { get; set; }
        public float mTrackLength { get; set; }
    }

    public class Timings
    {
        public bool mLapInvalidated { get; set; }
        public float mBestLapTime { get; set; }
        public float mLastLapTime { get; set; }
        public float mCurrentTime { get; set; }
        public float mSplitTimeAhead { get; set; }
        public float mSplitTimeBehind { get; set; }
        public float mSplitTime { get; set; }
        public float mEventTimeRemaining { get; set; }
        public float mPersonalFastestLapTime { get; set; }
        public float mWorldFastestLapTime { get; set; }
        public float mCurrentSector1Time { get; set; }
        public float mCurrentSector2Time { get; set; }
        public float mCurrentSector3Time { get; set; }
        public float mFastestSector1Time { get; set; }
        public float mFastestSector2Time { get; set; }
        public float mFastestSector3Time { get; set; }
        public float mPersonalFastestSector1Time { get; set; }
        public float mPersonalFastestSector2Time { get; set; }
        public float mPersonalFastestSector3Time { get; set; }
        public float mWorldFastestSector1Time { get; set; }
        public float mWorldFastestSector2Time { get; set; }
        public float mWorldFastestSector3Time { get; set; }
    }

    public class Flags
    {
        public int mHighestFlagColour { get; set; }
        public int mHighestFlagReason { get; set; }
    }

    public class Pitinfo
    {
        public int mPitMode { get; set; }
        public int mPitSchedule { get; set; }
    }

    public class Carstate
    {
        public int mCarFlags { get; set; }
        public float mOilTempCelsius { get; set; }
        public float mWaterTempCelsius { get; set; }
        public float mWaterPressureKPa { get; set; }
        public float mFuelPressureKPa { get; set; }
        public float mFuelLevel { get; set; }
        public float mFuelCapacity { get; set; }
        public float mSpeed { get; set; }
        public float mRpm { get; set; }
        public float mMaxRPM { get; set; }
        public float mBrake { get; set; }
        public float mThrottle { get; set; }
        public float mClutch { get; set; }
        public float mSteering { get; set; }
        public int mGear { get; set; }
        public int mNumGears { get; set; }
        public float mOdometerKM { get; set; }
        public bool mAntiLockActive { get; set; }
        public int mLastOpponentCollisionIndex { get; set; }
        public float mLastOpponentCollisionMagnitude { get; set; }
        public bool mBoostActive { get; set; }
        public float mBoostAmount { get; set; }
    }

    public class Motionanddevicerelated
    {
        public float[] mOrientation { get; set; }
        public float[] mLocalVelocity { get; set; }
        public float[] mWorldVelocity { get; set; }
        public float[] mAngularVelocity { get; set; }
        public float[] mLocalAcceleration { get; set; }
        public float[] mWorldAcceleration { get; set; }
        public float[] mExtentsCentre { get; set; }
    }

    public class Wheelsandtyres
    {
        public int[] mTyreFlags { get; set; }
        public int[] mTerrain { get; set; }
        public float[] mTyreY { get; set; }
        public float[] mTyreRPS { get; set; }
        public float[] mTyreSlipSpeed { get; set; }
        public float[] mTyreTemp { get; set; }
        public float[] mTyreGrip { get; set; }
        public float[] mTyreHeightAboveGround { get; set; }
        public float[] mTyreLateralStiffness { get; set; }
        public float[] mTyreWear { get; set; }
        public float[] mBrakeDamage { get; set; }
        public float[] mSuspensionDamage { get; set; }
        public float[] mBrakeTempCelsius { get; set; }
        public float[] mTyreTreadTemp { get; set; }
        public float[] mTyreLayerTemp { get; set; }
        public float[] mTyreCarcassTemp { get; set; }
        public float[] mTyreRimTemp { get; set; }
        public float[] mTyreInternalAirTemp { get; set; }
    }

    public class Cardamage
    {
        public int mCrashState { get; set; }
        public float mAeroDamage { get; set; }
        public float mEngineDamage { get; set; }
    }

    public class Weather
    {
        public float mAmbientTemperature { get; set; }
        public float mTrackTemperature { get; set; }
        public float mRainDensity { get; set; }
        public float mWindSpeed { get; set; }
        public float mWindDirectionX { get; set; }
        public float mWindDirectionY { get; set; }
        public float mCloudBrightness { get; set; }
    }

}
