using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_chassis : CollectionWrapperBase {
        #region Field Names
        public const string Name_WHEEL_BASE = "WHEEL_BASE";
        public const string Name_COLLISION_MASS = "COLLISION_MASS";
        public const string Name_DRAG_COEFFICIENT = "DRAG_COEFFICIENT";
        public const string Name_ROLL_SPEED = "ROLL_SPEED";
        public const string Name_SHOCK_VALVING = "SHOCK_VALVING";
        public const string Name_RIDE_HEIGHT = "RIDE_HEIGHT";
        public const string Name_MASS = "MASS";
        public const string Name_SHOCK_STIFFNESS = "SHOCK_STIFFNESS";
        public const string Name_SHOCK_BLOWOUT = "SHOCK_BLOWOUT";
        public const string Name_SHOCK_EXT_STIFFNESS = "SHOCK_EXT_STIFFNESS";
        public const string Name_SWAYBAR_STIFFNESS = "SWAYBAR_STIFFNESS";
        public const string Name_ROLL_CENTER = "ROLL_CENTER";
        public const string Name_TRAVEL = "TRAVEL";
        public const string Name_SPRING_STIFFNESS = "SPRING_STIFFNESS";
        public const string Name_TENSOR_SCALE = "TENSOR_SCALE";
        public const string Name_DIVE_SPEED = "DIVE_SPEED";
        public const string Name_0x8E493CDE = "0x8E493CDE";
        public const string Name_AERO_CG = "AERO_CG";
        public const string Name_SPRING_PROGRESSION = "SPRING_PROGRESSION";
        public const string Name_TRACK_WIDTH = "TRACK_WIDTH";
        public const string Name_SHOCK_DIGRESSION = "SHOCK_DIGRESSION";
        public const string Name_RENDER_MOTION = "RENDER_MOTION";
        public const string Name_AERO_COEFFICIENT = "AERO_COEFFICIENT";
        public const string Name_SQUAT_SPEED = "SQUAT_SPEED";
        public const string Name_FRONT_AXLE = "FRONT_AXLE";
        public const string Name_FRONT_WEIGHT_BIAS = "FRONT_WEIGHT_BIAS";
        #endregion

        public WORLD_chassis(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single AERO_CG() {
            return GetValue<System.Single>("AERO_CG");
        }
        public System.Single AERO_COEFFICIENT() {
            return GetValue<System.Single>("AERO_COEFFICIENT");
        }
        public System.Single COLLISION_MASS() {
            return GetValue<System.Single>("COLLISION_MASS");
        }
        public System.Single DIVE_SPEED() {
            return GetValue<System.Single>("DIVE_SPEED");
        }
        public System.Single DRAG_COEFFICIENT() {
            return GetValue<System.Single>("DRAG_COEFFICIENT");
        }
        public System.Single field_0x8E493CDE() {
            return GetValue<System.Single>("0x8E493CDE");
        }
        public System.Single FRONT_AXLE() {
            return GetValue<System.Single>("FRONT_AXLE");
        }
        public System.Single FRONT_WEIGHT_BIAS() {
            return GetValue<System.Single>("FRONT_WEIGHT_BIAS");
        }
        public System.Single MASS() {
            return GetValue<System.Single>("MASS");
        }
        public System.Single RENDER_MOTION() {
            return GetValue<System.Single>("RENDER_MOTION");
        }
        public VaultLib.Support.World.VLT.AxlePair RIDE_HEIGHT() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("RIDE_HEIGHT");
        }
        public System.Single ROLL_CENTER() {
            return GetValue<System.Single>("ROLL_CENTER");
        }
        public System.Single ROLL_SPEED() {
            return GetValue<System.Single>("ROLL_SPEED");
        }
        public System.Single SHOCK_BLOWOUT() {
            return GetValue<System.Single>("SHOCK_BLOWOUT");
        }
        public VaultLib.Support.World.VLT.AxlePair SHOCK_DIGRESSION() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SHOCK_DIGRESSION");
        }
        public VaultLib.Support.World.VLT.AxlePair SHOCK_EXT_STIFFNESS() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SHOCK_EXT_STIFFNESS");
        }
        public VaultLib.Support.World.VLT.AxlePair SHOCK_STIFFNESS() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SHOCK_STIFFNESS");
        }
        public VaultLib.Support.World.VLT.AxlePair SHOCK_VALVING() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SHOCK_VALVING");
        }
        public VaultLib.Support.World.VLT.AxlePair SPRING_PROGRESSION() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SPRING_PROGRESSION");
        }
        public VaultLib.Support.World.VLT.AxlePair SPRING_STIFFNESS() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SPRING_STIFFNESS");
        }
        public System.Single SQUAT_SPEED() {
            return GetValue<System.Single>("SQUAT_SPEED");
        }
        public VaultLib.Support.World.VLT.AxlePair SWAYBAR_STIFFNESS() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("SWAYBAR_STIFFNESS");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 TENSOR_SCALE() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("TENSOR_SCALE");
        }
        public VaultLib.Support.World.VLT.AxlePair TRACK_WIDTH() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("TRACK_WIDTH");
        }
        public VaultLib.Support.World.VLT.AxlePair TRAVEL() {
            return GetValue<VaultLib.Support.World.VLT.AxlePair>("TRAVEL");
        }
        public System.Single WHEEL_BASE() {
            return GetValue<System.Single>("WHEEL_BASE");
        }
        #endregion

    }
}