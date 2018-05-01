﻿namespace Multiplayer.Common
{
    public enum CommandType
    {
        // Global scope
        WORLD_TIME_SPEED,
        AUTOSAVE,
        SETUP_FACTION,
        GLOBAL_ID_BLOCK,

        // Mixed scope
        SYNC,

        // Map scope
        MAP_TIME_SPEED,
        CREATE_MAP_FACTION_DATA,
        MAP_ID_BLOCK,
        FORBID,
        DESIGNATOR,
        ORDER_JOB,
        DELETE_ZONE,
        SPAWN_PAWN,
    }

    public class ScheduledCommand
    {
        public const int GLOBAL = -1;

        public readonly CommandType type;
        public readonly int ticks;
        public readonly int mapId;
        public readonly byte[] data;

        public ScheduledCommand(CommandType type, int ticks, int mapId, byte[] data)
        {
            this.type = type;
            this.ticks = ticks;
            this.mapId = mapId;
            this.data = data;
        }
    }
}