using System;

namespace Domain
{
    [Serializable]
    public class LuggageRoom
    {
        public int _luggageRoomHeight;
        public int _luggageRoomWidth;
        public int _luggageRoomDepth;

        public LuggageRoom(int luggageRoomHeight, int luggageRoomWidth, int luggageRoomDepth)
        {
            this._luggageRoomHeight = luggageRoomHeight;
            this._luggageRoomWidth = luggageRoomWidth;
            this._luggageRoomDepth = luggageRoomDepth;
        }

        public LuggageRoom()
        {
        }
    }
}