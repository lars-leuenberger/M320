using System;

namespace Wasserfass
{
    public class Wasserfass
    {
        private readonly int _minimalPegel = 0;
        private readonly int _maximalPegel;
        private int _füllstand;

        public int Füllstand => _füllstand;
        public int Kapazität => _maximalPegel;

        public Wasserfass(int kapazität)
        {
            if (kapazität <= 0)
                throw new ArgumentException("Kapazität muss grösser als 0 sein.");

            _maximalPegel = kapazität;
            _füllstand = 0;
        }

        public void Befüllen(int menge)
        {
            if (menge <= 0)
                throw new ArgumentException("Menge muss grösser als 0 sein.");

            if (_füllstand + menge > _maximalPegel)
                throw new WasserfassOverflowException();

            _füllstand += menge;
        }

        public void Entnehmen(int menge)
        {
            if (menge <= 0)
                throw new ArgumentException("Menge muss grösser als 0 sein.");

            if (_füllstand - menge < _minimalPegel)
                throw new WasserfassUnderflowException();

            _füllstand -= menge;
        }

        public void Entleeren()
        {
            _füllstand = _minimalPegel;
        }
    }
}
