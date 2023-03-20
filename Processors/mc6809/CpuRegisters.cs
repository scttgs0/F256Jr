﻿
using System;
using FoenixCore.Processor.GenericNew;


namespace FoenixCore.Processor.mc6809
{
    public partial class CentralProcessingUnit
    {
        public ushort PC = 0;

        /// <summary>
        /// Accumulator
        /// </summary>
        public Register<byte> A = new();

        /// <summary>
        /// Accumulator
        /// </summary>
        public Register<byte> B = new();

        /// <summary>
        /// Accumulator
        /// </summary>
        public Register<ushort> D = new();

        /// <summary>
        /// X Index Regiser
        /// </summary>
        public Register<ushort> X = new();

        /// <summary>
        /// Y Index Register
        /// </summary>
        public Register<ushort> Y = new();

        /// <summary>
        /// Processor Status Register
        /// </summary>
        public CpuFlags Flags = new();

        /// <summary>
        /// Stack Pointer. The stack is always in the first 64KB page.
        /// </summary>
        public RegisterStackPointer Stack = new();

        /// <summary>
        /// Wait state. When Wait is true, the CoreCpu will not execute instructions. It
        /// will service the IRQ, NMI, and ABORT lines. A hardware interrupt is required
        /// to restart the CoreCpu.
        /// </summary>
        public bool Waiting;

        /// <summary>
        /// Processor status register (P)
        /// </summary>
        public CpuFlags P => Flags;

        /// <summary>
        /// Stack pointer (S)
        /// </summary>
        public Register<ushort> S => Stack;

        /// <summary>
        /// Stack pointer (S)
        /// </summary>
        public Register<ushort> U => Stack;

        public TimeSpan CycleTime => DateTime.Now - checkStartTime;
    }
}
