using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    internal class WasserfassBackup
    {
    }
}

/*
 * WASSERFASS OHNE EXCEPTION HANDLING
 * ==============================================================================================================================
using System;

namespace WasserfassProjekt
{
    public enum WasserfassStatus
    {
        Ok = 0,
        UngueltigeMenge = -1,
        Ueberlauf = -2,
        Unterlauf = -3
    }

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

        public WasserfassStatus Befüllen(int menge)
        {
            if (menge <= 0)
                return WasserfassStatus.UngueltigeMenge;

            if (_füllstand + menge > _maximalPegel)
            {
                _füllstand = _maximalPegel;
                return WasserfassStatus.Ueberlauf;
            }

            _füllstand += menge;
            return WasserfassStatus.Ok;
        }

        public WasserfassStatus Entnehmen(int menge)
        {
            if (menge <= 0)
                return WasserfassStatus.UngueltigeMenge;

            if (_füllstand - menge < _minimalPegel)
            {
                _füllstand = _minimalPegel;
                return WasserfassStatus.Unterlauf;
            }

            _füllstand -= menge;
            return WasserfassStatus.Ok;
        }

        public void Entleeren()
        {
            _füllstand = _minimalPegel;
        }
    }
}
*/

/*
 * WASSERFASS MIT EXCEPTION HANDLING -> INT RÜCKGABEN
 * ==============================================================================================================================
using System;

namespace WasserfassProjekt
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

        // Fehlercodes:
        //  0 = OK
        // -1 = Ungültige Menge
        // -2 = Überlauf
        // -3 = Unterlauf

        public int Befüllen(int menge)
        {
            if (menge <= 0)
                return -1;

            if (_füllstand + menge > _maximalPegel)
            {
                _füllstand = _maximalPegel;
                return -2;
            }

            _füllstand += menge;
            return 0;
        }

        public int Entnehmen(int menge)
        {
            if (menge <= 0)
                return -1;

            if (_füllstand - menge < _minimalPegel)
            {
                _füllstand = _minimalPegel;
                return -3;
            }

            _füllstand -= menge;
            return 0;
        }

        public void Entleeren()
        {
            _füllstand = _minimalPegel;
        }
    }
}
*/

/*
 * WASSERFASS MIT EXCEPTION HANDLING -> ENUM
 * ==============================================================================================================================
using System;

namespace WasserfassProjekt
{
    public enum WasserfassStatus
    {
        Ok = 0,
        UngueltigeMenge = -1,
        Ueberlauf = -2,
        Unterlauf = -3
    }

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

        public WasserfassStatus Befüllen(int menge)
        {
            if (menge <= 0)
                return WasserfassStatus.UngueltigeMenge;

            if (_füllstand + menge > _maximalPegel)
            {
                _füllstand = _maximalPegel;
                return WasserfassStatus.Ueberlauf;
            }

            _füllstand += menge;
            return WasserfassStatus.Ok;
        }

        public WasserfassStatus Entnehmen(int menge)
        {
            if (menge <= 0)
                return WasserfassStatus.UngueltigeMenge;

            if (_füllstand - menge < _minimalPegel)
            {
                _füllstand = _minimalPegel;
                return WasserfassStatus.Unterlauf;
            }

            _füllstand -= menge;
            return WasserfassStatus.Ok;
        }

        public void Entleeren()
        {
            _füllstand = _minimalPegel;
        }
    }
}
*/

