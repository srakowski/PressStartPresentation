using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PressStart
{
    static class Input
    {
        private static KeyboardState _prevKB;
        private static KeyboardState _currKB;
        private static GamePadState _prevGP;
        private static GamePadState _currGP;

        public static void Update()
        {
            _prevKB = _currKB;
            _currKB = Keyboard.GetState();
            _prevGP = _currGP;
            _currGP = GamePad.GetState(PlayerIndex.One);
        }

        public static bool WasKeyPressed(Keys key) =>
           _currKB.IsKeyUp(key) && _prevKB.IsKeyDown(key);

        public static bool WasButtonPressed(Buttons button) =>
            _currGP.IsButtonUp(button) && _prevGP.IsButtonDown(button);
    }
}
