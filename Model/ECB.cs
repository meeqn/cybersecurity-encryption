﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurity_encryption.Model
{
    internal class ECB : Encryption
    {
        public ECB(byte[] key, byte[] message) : base(key, message) {}

        public override byte[] Encrypt(byte[] key, byte[] message)
        {
            //TODO implement ECB
            return message;
        }
        public override byte[] Decrypt(byte[] key, byte[] message)
        {
            //TODO implement ECB
            return message;
        }
    }
}
