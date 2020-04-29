﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PMDDotNET.Compiler
{
	public class fnumdat_seg
	{
		public int[] fnumTbl = new int[]
		{
			//;******* block=3 c********
			0x26a,0x26b,0x26c,0x26e,0x26f,0x270,0x271,0x272,
			0x273,0x274,0x276,0x277,0x278,0x279,0x27a,0x27b,
			0x27c,0x27e,0x27f,0x280,0x281,0x282,0x283,0x284,
			0x286,0x287,0x288,0x289,0x28a,0x28b,0x28d,0x28e,

			//;******* block=3 c# *******
			0x28f,0x290,0x291,0x293,0x294,0x295,0x296,0x297,
			0x299,0x29a,0x29b,0x29c,0x29d,0x29f,0x2a0,0x2a1,
			0x2a2,0x2a3,0x2a5,0x2a6,0x2a7,0x2a8,0x2aa,0x2ab,
			0x2ac,0x2ad,0x2ae,0x2b0,0x2b1,0x2b2,0x2b3,0x2b5,

			//;******* block=3 d *******
			0x2b6,0x2b7,0x2b8,0x2ba,0x2bb,0x2bc,0x2bd,0x2bf,
			0x2c0,0x2c1,0x2c3,0x2c4,0x2c5,0x2c6,0x2c8,0x2c9,
			0x2ca,0x2cc,0x2cd,0x2ce,0x2cf,0x2d1,0x2d2,0x2d3,
			0x2d5,0x2d6,0x2d7,0x2d9,0x2da,0x2db,0x2dd,0x2de,

			//;******* block=3 d# *******
			0x2df,0x2e1,0x2e2,0x2e3,0x2e5,0x2e6,0x2e7,0x2e9,
			0x2ea,0x2eb,0x2ed,0x2ee,0x2ef,0x2f1,0x2f2,0x2f3,
			0x2f5,0x2f6,0x2f8,0x2f9,0x2fa,0x2fc,0x2fd,0x2fe,
			0x300,0x301,0x303,0x304,0x305,0x307,0x308,0x30a,

			//;******* block=3 e *******
			0x30b,0x30c,0x30e,0x30f,0x311,0x312,0x313,0x315,
			0x316,0x318,0x319,0x31b,0x31c,0x31d,0x31f,0x320,
			0x322,0x323,0x325,0x326,0x328,0x329,0x32a,0x32c,
			0x32d,0x32f,0x330,0x332,0x333,0x335,0x336,0x338,

			//;******* block=3 f *******
			0x339,0x33b,0x33c,0x33e,0x33f,0x341,0x342,0x344,
			0x345,0x347,0x348,0x34a,0x34b,0x34d,0x34f,0x350,
			0x352,0x353,0x355,0x356,0x358,0x359,0x35b,0x35c,
			0x35e,0x35f,0x361,0x363,0x364,0x366,0x367,0x369,

			//;******* block=3 f# *******
			0x36a,0x36c,0x36d,0x36f,0x371,0x372,0x374,0x375,
			0x377,0x379,0x37a,0x37c,0x37d,0x37f,0x381,0x382,
			0x384,0x386,0x387,0x389,0x38a,0x38c,0x38e,0x38f,
			0x391,0x393,0x394,0x396,0x398,0x399,0x39b,0x39d,

			//;******* block=3 g *******
			0x39e,0x3a0,0x3a2,0x3a3,0x3a5,0x3a7,0x3a8,0x3aa,
			0x3ac,0x3ad,0x3af,0x3b1,0x3b3,0x3b4,0x3b6,0x3b8,
			0x3b9,0x3bb,0x3bd,0x3bf,0x3c0,0x3c2,0x3c4,0x3c6,
			0x3c7,0x3c9,0x3cb,0x3cd,0x3ce,0x3d0,0x3d2,0x3d4,

			//;******* block=3 g# *******
			0x3d5,0x3d7,0x3d9,0x3db,0x3dc,0x3de,0x3e0,0x3e2,
			0x3e4,0x3e5,0x3e7,0x3e9,0x3eb,0x3ed,0x3ef,0x3f0,
			0x3f2,0x3f4,0x3f6,0x3f8,0x3f9,0x3fb,0x3fd,0x3ff,
			0x401,0x403,0x405,0x406,0x408,0x40a,0x40c,0x40e,

			//;******* block=3 a *******
			0x410,0x412,0x414,0x415,0x417,0x419,0x41b,0x41d,
			0x41f,0x421,0x423,0x425,0x427,0x428,0x42a,0x42c,
			0x42e,0x430,0x432,0x434,0x436,0x438,0x43a,0x43c,
			0x43e,0x440,0x442,0x444,0x446,0x448,0x44a,0x44c,

			//;******* block=3 a# *******
			0x44e,0x450,0x452,0x454,0x456,0x458,0x45a,0x45c,
			0x45e,0x460,0x462,0x464,0x466,0x468,0x46a,0x46c,
			0x46e,0x470,0x472,0x474,0x476,0x478,0x47a,0x47c,
			0x47e,0x480,0x483,0x485,0x487,0x489,0x48b,0x48d,

			//;******* block=3 b *******
			0x48f,0x491,0x493,0x495,0x498,0x49a,0x49c,0x49e,
			0x4a0,0x4a2,0x4a4,0x4a6,0x4a9,0x4ab,0x4ad,0x4af,
			0x4b1,0x4b3,0x4b6,0x4b8,0x4ba,0x4bc,0x4be,0x4c1,
			0x4c3,0x4c5,0x4c7,0x4c9,0x4cc,0x4ce,0x4d0,0x4d2,

		};
	}
}