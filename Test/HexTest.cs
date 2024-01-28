using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NaotDefines;

namespace Test;
class HexTest
{
    static HexTest()
    {
        f = new byte[16];
        f[0] = 0;
        f[1] = 1;
        f[2] = 60;

        byte[] bytes = [2,23,3,3,3,3,3,3,3];
        Console.WriteLine(bytes);
        
        Console.WriteLine(f.ToArray());

        byte[] b = bytes.ToArray();
    }

    static byte[] f;

    byte value;
    TestHexStruct structVariable;
    byte[] variable;
    List<byte[]> variable_2;
    TestHexClass variable_3;

    public void hextest()
    {
        var _ = new object();
        { } { } { }
        
        _ = hex((double[])[1, 0, 1, 0, 0, 1]);
        { } { } { }
        _ = hex(); // byte[0]
        { } { } { }
        _ = hex(new byte[0]); // byte[0]
        { } { } { }
        _ = hex(new long[0]); // byte[0]
        { } { } { }
        _ = hex(new string[1] { "F0 "}); // F0
        { } { } { }
        _ = hex(new string[0]); // byte[0]
        { } { } { }
        _ = hex(new object[2] { new string[0], new string[0] }); // byte[0]
        { } { } { }
        _ = hex(new string[0], 0x40);
        { } { } { }
        
        _ = hex(
            2d,
            new object[2]
            {
                80,
                "00DD"
            },
            (ushort)70,
            new object[] 
            {
                new object[4]
                { 
                    40, 
                    30, 
                    new object[0],
                    new object[2]
                    { 
                        20,
                        10
                    } 
                }, 
                "FE00",
                50 
            }, 
            90, 
            100
        );
        

        { } { } { }
        _ = hex(0); // 00 00 00 00
        { } { } { }
        _ = hex(1d); // 00 00 00 00 00 00 F0 3F
        { } { } { }
        _ = hex(""); // byte[0]
        { } { } { }
        _ = hex("00"); // 00
        { } { } { }
        _ = hex("00FFED0D"); // 00 FF ED 0D
        { } { } { }
        
        _ = hex("00 FF ED 0D"); // 00 FF ED 0D
        { } { } { }
        _ = hex("0x30 FF ED 0D"); // 30 FF ED 0D
        { } { } { }
        _ = hex("30 FF ED 0D"); // 30 FF ED 0D
        { } { } { }
        _ = hex("0 FF ED D"); // 00 FF ED 0D
        { } { } { }
        _ = hex("0, FF ED, D"); // 00 FF ED 0D
        { } { } { }
        _ = hex("0 FF 0xED 0xD"); // 00 FF ED 0D
        { } { } { }
        _ = hex("0 FF 0xED D"); // 00 FF ED 0D
        { } { } { }
        _ = hex("0 FF 0xED D", (byte)0x30, "FF FE"); // 00 FF ED 0D  30  FF FE
        { } { } { }
        _ = hex("0 FF 0xED D", (byte[])[0x30, 0, 0, 0xFF], "FF FE"); // 00 FF ED 0D  30 0 0 FF  FF FE
        { } { } { }
        _ = hex(900L, (byte)0x90, "FFBED0", 1d); // 84 03 00 00 00 00 00 00  90  FF BE D0  00 00 00 00 00 00 F0 3F
        { } { } { }
        variable = hex("00FFED0D", 50);
        { } { } { }
        variable_2 = [[0x30, 0x40], hex("00FFED0D", 50)];
        
        { } { } { }
        variable_3 = new(hex("00FFED0D", 50));

        /*
        { } { } { }
        { } { } { }
        { } { } { }

        _ = hex(new object());
        { } { } { }
        _ = hex(new BadImageFormatException());
        { } { } { }
        _ = hex(null);
        { } { } { }
        _ = hex(new TestHexStruct());
        { } { } { }
        _ = hex(structVariable);
        { } { } { }
        _ = hex("0 FF 0xED D", (byte[])[0x30, value, 0, 0xFF], "FF FE");

        { } { } { }
        { } { } { }
        { } { } { }

        _ = new byte[0];
        { } { } { }
        _ = new byte[4] { 0, 1, 2, 3 };
        _ = new byte[5] { 0, 1, 2, 3, 4 };
        _ = new byte[6] { 0, 1, 2, 3, 4, 5 };
        _ = new byte[6] { 0, 1, 2, 3, 4, 10 };
        _ = new byte[6] { 0, 1, 2, 3, 4, 10 };
        _ = new byte[7] { 0, 1, 2, 3, 4, 5, 6 };
        { } { } { }
        _ = new byte[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        { } { } { }
        */
    }
}

class TestHexClass
{
    public TestHexClass(byte[] arr) { }
}

struct TestHexStruct;