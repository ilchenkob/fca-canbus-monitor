﻿using System;

namespace CanBusMonitor.PoC.Parsing.Nodes
{
    public class NodeReaderFactory
    {
        public INodeReader CreateNodeReader(CanMessage canMessage)
        {
            switch (canMessage.Identifier)
            {
                case MOT1NodeReader.TypeIdentifier:
                    return new MOT1NodeReader(canMessage);
                case MOT2NodeReader.TypeIdentifier:
                    return new MOT2NodeReader(canMessage);
                case ASR1NodeReader.TypeIdentifier:
                    return new ASR1NodeReader(canMessage);
                case ASR2NodeReader.TypeIdentifier:
                    return new ASR2NodeReader(canMessage);
                case STNBNodeReader.TypeIdentifier:
                    return new STNBNodeReader(canMessage);
                case MOTGEARNodeReader.TypeIdentifier:
                    return new MOTGEARNodeReader(canMessage);
                case STNB_CUSW11NodeReader.TypeIdentifier:
                    return new STNB_CUSW11NodeReader(canMessage);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
