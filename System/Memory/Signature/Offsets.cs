using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryManipulator
{
    class Offsets
    {

        /*
        * AFAIK no better way to store and compare object types?
        * While I could use Type.Equals() or typeof() I'd still need to store the type
        * of the object - and to do that I need to either init a new object of that type
        * (eg; new float(), new bool()) - or I could just use this enum considering its also 4 bytes in ram
        */
        public enum ObjectType { FLOAT, INT, STRING, BOOL }

        // Entity attributes - Returns decimal offset to obtain the value represented, and presumed object type
        public class Attribute
        {
            // Memory offset from base address, in decimal
            public int offset;

            // Primitive value type
            public ObjectType type;

            // Corresponding UI element
            public Control node;

            public Attribute(int offset, ObjectType type, Control node)
            {
                this.offset = offset;
                this.type = type;
                this.node = node;
            }

            public static List<Attribute> ToList(Type type)
            {
                List<Attribute> attributes = new List<Attribute>(29);

                // Use reflection to iterate all methods in class and get returned attribute objects
                foreach (var method in type.GetMethods())
                {
                    if (method.ReturnType.Equals(typeof(Attribute)))
                    {
                        Attribute att = (Attribute)method.Invoke(type, null);

                        if (att != null)
                            attributes.Add(att);
                    }
                }

                return attributes;
            }
        }

        public abstract class PlayerAttributes
        {
            public static Attribute INVENTORY => new Attribute(208, ObjectType.INT, null);
            public static Attribute SELECTED => new Attribute(792, ObjectType.INT, null);
            public static Attribute DIFFICULTY => new Attribute(1697, ObjectType.INT, Program.overlay.difficultyValue);
            public static Attribute MAXLIFE => new Attribute(976, ObjectType.INT, Program.overlay.maxLifeValue);
            public static Attribute MAXMANA => new Attribute(992, ObjectType.INT, Program.overlay.maxManaValue);
            public static Attribute MAXBREATH => new Attribute(824, ObjectType.INT, Program.overlay.maxBreathValue);
            public static Attribute DRAG => new Attribute(1148, ObjectType.FLOAT, Program.overlay.dragValue);
            public static Attribute GRAVITY => new Attribute(1132, ObjectType.FLOAT, Program.overlay.gravityValue);
            public static Attribute MAXSPEED => new Attribute(1140, ObjectType.FLOAT, Program.overlay.maxSpeedValue);
            public static Attribute ACCELERATION => new Attribute(1144, ObjectType.FLOAT, Program.overlay.accelerationValue);
        }

        public abstract class NpcAttributes
        {
            //TODO double check obj types, convert offsets to decimal
            public static Attribute NETID => new Attribute(300, ObjectType.INT, null);
            public static Attribute TYPE => new Attribute(220, ObjectType.INT, Program.overlay.npcType);
            public static Attribute BOSS => new Attribute(409, ObjectType.INT, Program.overlay.npcBoss);
            public static Attribute TOWN => new Attribute(25, ObjectType.INT, Program.overlay.npcTown);
            public static Attribute STYLE => new Attribute(228, ObjectType.INT, Program.overlay.npcStyle);

            public static Attribute SCALE => new Attribute(268, ObjectType.INT, Program.overlay.npcScale);
            public static Attribute SPEED => new Attribute(184, ObjectType.INT, Program.overlay.npcSpeed);
            public static Attribute DAMAGE => new Attribute(240, ObjectType.INT, Program.overlay.npcDamage);
            public static Attribute LIFE => new Attribute(256, ObjectType.INT, Program.overlay.npcLife);
            public static Attribute MAXLIFE => new Attribute(260, ObjectType.INT, Program.overlay.npcMax);

            public static Attribute FRIENDLY => new Attribute(416, ObjectType.BOOL, Program.overlay.isFriendly);
            public static Attribute INVINCIBLE => new Attribute(412, ObjectType.BOOL, Program.overlay.isInvincible);
            public static Attribute NOCLIP => new Attribute(404, ObjectType.BOOL, Program.overlay.noColliision);
            public static Attribute CLOSEDOORS => new Attribute(417, ObjectType.BOOL, Program.overlay.closeDoors);
            public static Attribute NOGRAVITY => new Attribute(403, ObjectType.BOOL, Program.overlay.noGravity);
        }

        public abstract class ItemAttributes
        {
            public static Attribute NETID => new Attribute(316, ObjectType.INT, null);
            public static Attribute TYPE => new Attribute(156, ObjectType.INT, Program.overlay.typeValue);
            public static Attribute SCALE => new Attribute(232, ObjectType.FLOAT, Program.overlay.scaleValue);
            public static Attribute STACK => new Attribute(176, ObjectType.INT, Program.overlay.stackValue);
            public static Attribute MAXSTACK => new Attribute(180, ObjectType.INT, Program.overlay.maxStackValue);
            public static Attribute SHINY => new Attribute(380, ObjectType.INT, Program.overlay.shinyValue);

            public static Attribute USETIME => new Attribute(172, ObjectType.INT, Program.overlay.useValue);
            public static Attribute AUTOREUSE => new Attribute(350, ObjectType.BOOL, Program.overlay.reuseValue);
            public static Attribute REUSEDELAY => new Attribute(324, ObjectType.INT, Program.overlay.delayValue);
            public static Attribute KNOCKBACK => new Attribute(216, ObjectType.FLOAT, Program.overlay.useValue);
            public static Attribute DAMAGE => new Attribute(212, ObjectType.INT, Program.overlay.damageValue);
            public static Attribute RANGE => new Attribute(196, ObjectType.INT, Program.overlay.rangeValue);

            public static Attribute AXE => new Attribute(188, ObjectType.INT, Program.overlay.axeValue);
            public static Attribute PICK => new Attribute(184, ObjectType.INT, Program.overlay.pickValue);
            public static Attribute HAMMER => new Attribute(192, ObjectType.INT, Program.overlay.hammerValue);

            public static Attribute TILEWAND => new Attribute(124, ObjectType.INT, Program.overlay.wandValue);
            public static Attribute CREATETILE => new Attribute(200, ObjectType.INT, Program.overlay.tileValue);
            public static Attribute CREATEWALL => new Attribute(204, ObjectType.INT, Program.overlay.wallValue);
            public static Attribute HEADSLOT => new Attribute(240, ObjectType.INT, Program.overlay.headValue);
            public static Attribute BODYSLOT => new Attribute(244, ObjectType.INT, Program.overlay.bodyValue);
            public static Attribute LEGSLOT => new Attribute(248, ObjectType.INT, Program.overlay.legValue);
            public static Attribute ACCESORY => new Attribute(347, ObjectType.BOOL, Program.overlay.accesoryValue);

            public static Attribute NOMELEE => new Attribute(366, ObjectType.BOOL, Program.overlay.noMeleeValue);
            public static Attribute MELEE => new Attribute(376, ObjectType.BOOL, Program.overlay.meleeValue);
            public static Attribute MAGIC => new Attribute(377, ObjectType.BOOL, Program.overlay.magicValue);
            public static Attribute RANGED => new Attribute(378, ObjectType.BOOL, Program.overlay.rangedValue);

            public static Attribute PROJECTILE => new Attribute(264, ObjectType.INT, Program.overlay.projectileValue);
            public static Attribute AMMOSPEED => new Attribute(268, ObjectType.FLOAT, Program.overlay.ammoSpeedValue);
            public static Attribute AMMOTYPE => new Attribute(276, ObjectType.INT, Program.overlay.ammoValue);

        }
    }
}
