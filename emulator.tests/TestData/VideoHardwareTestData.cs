using System.Drawing;
using Xunit;

namespace JustinCredible.PacEmu.Tests
{
    public class VideoHardwareTestData
    {
        public static readonly byte[] COLOR_ROM = new byte[]
        {
            0x00, 0x07, 0x66, 0xef, 0x00, 0xf8, 0xea, 0x6f, 0x00, 0x3f, 0x00, 0xc9, 0x38, 0xaa, 0xaf, 0xf6,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        };

        public static readonly byte[] PALETTE_ROM = new byte[]
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0b, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0b, 0x03,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0b, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0b, 0x07,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, 0x01, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x00, 0x0e, 0x00, 0x01, 0x0c, 0x0f,
            0x00, 0x0e, 0x00, 0x0b, 0x00, 0x0c, 0x0b, 0x0e, 0x00, 0x0c, 0x0f, 0x01, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x01, 0x02, 0x0f, 0x00, 0x07, 0x0c, 0x02, 0x00, 0x09, 0x06, 0x0f, 0x00, 0x0d, 0x0c, 0x0f,
            0x00, 0x05, 0x03, 0x09, 0x00, 0x0f, 0x0b, 0x00, 0x00, 0x0e, 0x00, 0x0b, 0x00, 0x0e, 0x00, 0x0b,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0e, 0x01, 0x00, 0x0f, 0x0b, 0x0e, 0x00, 0x0e, 0x00, 0x0f,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        };

        public static readonly byte[] TILE_ROM = new byte[]
        {
            0xcc, 0xee, 0x11, 0x11, 0x33, 0xee, 0xcc, 0x00, 0x11, 0x33, 0x66, 0x44, 0x44, 0x33, 0x11, 0x00,
            0x11, 0x11, 0xff, 0xff, 0x11, 0x11, 0x00, 0x00, 0x00, 0x00, 0x77, 0x77, 0x22, 0x00, 0x00, 0x00,
            0x11, 0x99, 0xdd, 0xdd, 0xff, 0x77, 0x33, 0x00, 0x33, 0x77, 0x55, 0x44, 0x44, 0x66, 0x22, 0x00,
            0x66, 0xff, 0x99, 0x99, 0x99, 0x33, 0x22, 0x00, 0x44, 0x66, 0x77, 0x55, 0x44, 0x44, 0x00, 0x00,
            0x44, 0xff, 0xff, 0x44, 0x44, 0xcc, 0xcc, 0x00, 0x00, 0x77, 0x77, 0x66, 0x33, 0x11, 0x00, 0x00,
            0xee, 0xff, 0x11, 0x11, 0x11, 0x33, 0x22, 0x00, 0x00, 0x55, 0x55, 0x55, 0x55, 0x77, 0x77, 0x00,
            0x66, 0xff, 0x99, 0x99, 0x99, 0xff, 0xee, 0x00, 0x00, 0x44, 0x44, 0x44, 0x66, 0x33, 0x11, 0x00,
            0x00, 0x00, 0x88, 0xff, 0x77, 0x00, 0x00, 0x00, 0x66, 0x77, 0x55, 0x44, 0x44, 0x66, 0x66, 0x00,
            0x66, 0x77, 0xdd, 0xdd, 0x99, 0x99, 0x66, 0x00, 0x00, 0x33, 0x44, 0x44, 0x55, 0x77, 0x33, 0x00,
            0xcc, 0xee, 0xbb, 0x99, 0x99, 0x99, 0x00, 0x00, 0x33, 0x77, 0x44, 0x44, 0x44, 0x77, 0x33, 0x00,
            0xff, 0xff, 0x44, 0x44, 0x44, 0xff, 0xff, 0x00, 0x11, 0x33, 0x66, 0x44, 0x66, 0x33, 0x11, 0x00,
            0x66, 0xff, 0x99, 0x99, 0x99, 0xff, 0xff, 0x00, 0x33, 0x77, 0x44, 0x44, 0x44, 0x77, 0x77, 0x00,
            0x22, 0x33, 0x11, 0x11, 0x33, 0xee, 0xcc, 0x00, 0x22, 0x66, 0x44, 0x44, 0x66, 0x33, 0x11, 0x00,
            0xcc, 0xee, 0x33, 0x11, 0x11, 0xff, 0xff, 0x00, 0x11, 0x33, 0x66, 0x44, 0x44, 0x77, 0x77, 0x00,
            0x11, 0x99, 0x99, 0x99, 0xff, 0xff, 0x00, 0x00, 0x44, 0x44, 0x44, 0x44, 0x77, 0x77, 0x00, 0x00,
            0x00, 0x88, 0x88, 0x88, 0x88, 0xff, 0xff, 0x00, 0x44, 0x44, 0x44, 0x44, 0x44, 0x77, 0x77, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x08, 0x0c, 0x0c, 0x08, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x03, 0x01, 0x00, 0x00,
            0x00, 0x00, 0x08, 0x0c, 0x0c, 0x08, 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x03, 0x01, 0x00, 0x00,
            0x0c, 0x0e, 0x0f, 0x0f, 0x0f, 0x0f, 0x0e, 0x0c, 0x03, 0x07, 0x0f, 0x0f, 0x0f, 0x0f, 0x07, 0x03,
            0x0c, 0x0e, 0x0f, 0x0f, 0x0f, 0x0f, 0x0e, 0x0c, 0x03, 0x07, 0x0f, 0x0f, 0x0f, 0x0f, 0x07, 0x03,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x77, 0xff, 0xff, 0xff, 0xee, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x33, 0x33,
            0xee, 0xcc, 0xcc, 0x88, 0x88, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x11, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88, 0x88, 0x00, 0x00, 0x00, 0xcc, 0xee, 0xff, 0xff, 0xff,
            0x88, 0x88, 0x88, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x77, 0x77, 0x33, 0x22, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xdd, 0x00, 0xee, 0xdd, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xdd, 0x00, 0xee, 0xdd, 0x00, 0x00,
            0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff, 0x77, 0xff, 0xcc, 0xcc, 0xcc, 0xcc, 0xff, 0xff,
            0xbb, 0xbb, 0xbb, 0xbb, 0xff, 0xff, 0x00, 0x00, 0xdd, 0xdd, 0xdd, 0xdd, 0xdd, 0x11, 0x00, 0x00,
            0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0xcc, 0xcc, 0xff, 0xff, 0x00, 0x00, 0x77, 0xff,
            0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x77, 0xff, 0xcc, 0xcc, 0xff, 0xff,
            0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0xff, 0xee, 0xcc, 0xcc, 0xcc, 0xcc, 0xcc, 0xcc, 0xff, 0x77,
            0x33, 0x33, 0x33, 0x33, 0xff, 0xee, 0x00, 0x00, 0xcc, 0xcc, 0xcc, 0xcc, 0xff, 0x77, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x77, 0xff,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x88, 0xcc, 0x22, 0x22, 0x66, 0xcc, 0x88, 0x00, 0x33, 0x77, 0xcc, 0x88, 0x88, 0x77, 0x33, 0x00,
            0x22, 0x22, 0xee, 0xee, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff, 0x44, 0x00, 0x00, 0x00,
            0x22, 0x22, 0xaa, 0xaa, 0xee, 0xee, 0x66, 0x00, 0x66, 0xff, 0xbb, 0x99, 0x99, 0xcc, 0x44, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0x66, 0x44, 0x00, 0x88, 0xdd, 0xff, 0xbb, 0x99, 0x88, 0x00, 0x00,
            0x88, 0xee, 0xee, 0x88, 0x88, 0x88, 0x88, 0x00, 0x00, 0xff, 0xff, 0xcc, 0x66, 0x33, 0x11, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0x66, 0x44, 0x00, 0x11, 0xbb, 0xaa, 0xaa, 0xaa, 0xee, 0xee, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0xee, 0xcc, 0x00, 0x00, 0x99, 0x99, 0x99, 0xdd, 0x77, 0x33, 0x00,
            0x00, 0x00, 0x00, 0xee, 0xee, 0x00, 0x00, 0x00, 0xcc, 0xee, 0xbb, 0x99, 0x88, 0xcc, 0xcc, 0x00,
            0xcc, 0xee, 0xaa, 0xaa, 0x22, 0x22, 0xcc, 0x00, 0x00, 0x66, 0x99, 0x99, 0xbb, 0xff, 0x66, 0x00,
            0x88, 0xcc, 0x66, 0x22, 0x22, 0x22, 0x00, 0x00, 0x77, 0xff, 0x99, 0x99, 0x99, 0xff, 0x66, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x88, 0x44, 0x22, 0x00, 0x88, 0x44, 0x22, 0x11, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x00, 0x00, 0x00,
            0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x88, 0x88, 0x88, 0x88, 0x88, 0x88, 0x88,
            0xff, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x88, 0x88, 0x88, 0x88, 0x88, 0x88, 0x88, 0xff,
            0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xee, 0xee, 0x88, 0x88, 0x88, 0xee, 0xee, 0x00, 0x33, 0x77, 0xcc, 0x88, 0xcc, 0x77, 0x33, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0xee, 0xee, 0x00, 0x66, 0xff, 0x99, 0x99, 0x99, 0xff, 0xff, 0x00,
            0x44, 0x66, 0x22, 0x22, 0x66, 0xcc, 0x88, 0x00, 0x44, 0xcc, 0x88, 0x88, 0xcc, 0x77, 0x33, 0x00,
            0x88, 0xcc, 0x66, 0x22, 0x22, 0xee, 0xee, 0x00, 0x33, 0x77, 0xcc, 0x88, 0x88, 0xff, 0xff, 0x00,
            0x22, 0x22, 0x22, 0x22, 0xee, 0xee, 0x00, 0x00, 0x88, 0x99, 0x99, 0x99, 0xff, 0xff, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0x00, 0x88, 0x99, 0x99, 0x99, 0x99, 0xff, 0xff, 0x00,
            0xee, 0xee, 0x22, 0x22, 0x66, 0xcc, 0x88, 0x00, 0x99, 0x99, 0x99, 0x88, 0xcc, 0x77, 0x33, 0x00,
            0xee, 0xee, 0x00, 0x00, 0x00, 0xee, 0xee, 0x00, 0xff, 0xff, 0x11, 0x11, 0x11, 0xff, 0xff, 0x00,
            0x22, 0x22, 0xee, 0xee, 0x22, 0x22, 0x00, 0x00, 0x88, 0x88, 0xff, 0xff, 0x88, 0x88, 0x00, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0x66, 0x44, 0x00, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x22, 0x66, 0xee, 0xcc, 0x88, 0xee, 0xee, 0x00, 0x88, 0xcc, 0x66, 0x33, 0x11, 0xff, 0xff, 0x00,
            0x22, 0x22, 0x22, 0x22, 0xee, 0xee, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00,
            0xee, 0xee, 0x00, 0x88, 0x00, 0xee, 0xee, 0x00, 0xff, 0xff, 0x77, 0x33, 0x77, 0xff, 0xff, 0x00,
            0xee, 0xee, 0xcc, 0x88, 0x00, 0xee, 0xee, 0x00, 0xff, 0xff, 0x11, 0x33, 0x77, 0xff, 0xff, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0xee, 0xcc, 0x00, 0x77, 0xff, 0x88, 0x88, 0x88, 0xff, 0x77, 0x00,
            0x00, 0x88, 0x88, 0x88, 0x88, 0xee, 0xee, 0x00, 0x77, 0xff, 0x88, 0x88, 0x88, 0xff, 0xff, 0x00,
            0xaa, 0xcc, 0xee, 0xaa, 0x22, 0xee, 0xcc, 0x00, 0x77, 0xff, 0x88, 0x88, 0x88, 0xff, 0x77, 0x00,
            0x22, 0x66, 0xee, 0xcc, 0x88, 0xee, 0xee, 0x00, 0x77, 0xff, 0x99, 0x88, 0x88, 0xff, 0xff, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0x66, 0x44, 0x00, 0x00, 0x55, 0xdd, 0x99, 0x99, 0xff, 0x66, 0x00,
            0x00, 0x00, 0xee, 0xee, 0x00, 0x00, 0x00, 0x00, 0x88, 0x88, 0xff, 0xff, 0x88, 0x88, 0x00, 0x00,
            0xcc, 0xee, 0x22, 0x22, 0x22, 0xee, 0xcc, 0x00, 0xff, 0xff, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00,
            0x00, 0x88, 0xcc, 0xee, 0xcc, 0x88, 0x00, 0x00, 0xff, 0xff, 0x11, 0x00, 0x11, 0xff, 0xff, 0x00,
            0xee, 0xee, 0xcc, 0x88, 0xcc, 0xee, 0xee, 0x00, 0xff, 0xff, 0x11, 0x33, 0x11, 0xff, 0xff, 0x00,
            0x66, 0xee, 0xcc, 0x88, 0xcc, 0xee, 0x66, 0x00, 0xcc, 0xee, 0x77, 0x33, 0x77, 0xee, 0xcc, 0x00,
            0x00, 0x00, 0xee, 0xee, 0x00, 0x00, 0x00, 0x00, 0xee, 0xff, 0x11, 0x11, 0xff, 0xee, 0x00, 0x00,
            0x22, 0x22, 0x22, 0xaa, 0xee, 0xee, 0x66, 0x00, 0xcc, 0xee, 0xff, 0xbb, 0x99, 0x88, 0x88, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x88, 0x22, 0x00, 0x00, 0x00, 0xcc, 0xee, 0xff, 0x33, 0x00, 0x00, 0x00,
            0xcc, 0x22, 0x11, 0x55, 0x55, 0x99, 0x22, 0xcc, 0x33, 0x44, 0x88, 0xaa, 0xaa, 0x99, 0x44, 0x33,
            0x00, 0x00, 0x00, 0x00, 0x88, 0x88, 0x88, 0xee, 0x22, 0x22, 0x00, 0x11, 0x22, 0x22, 0x22, 0x33,
            0xaa, 0xaa, 0xaa, 0x22, 0x00, 0x00, 0x00, 0xee, 0x22, 0x22, 0x22, 0x11, 0x00, 0x22, 0x22, 0x33,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x44, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0e, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x33, 0x77, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0x00,
            0x33, 0x33, 0x77, 0x77, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x33, 0x33,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee,
            0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0xee, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x33, 0x33, 0x33, 0x33, 0x33, 0x77, 0x77, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee, 0xee,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x11, 0x33, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xee, 0xee, 0xee, 0xee, 0xee, 0x00, 0x00, 0x00,
            0x33, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xce, 0xee, 0xee, 0xee, 0x66, 0x22, 0x22, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x22, 0xcc, 0x00, 0x22, 0xee, 0x22, 0x00, 0x00, 0x88, 0x77, 0x00, 0x00, 0xff, 0x44, 0x00, 0x00,
            0x22, 0xcc, 0x00, 0xcc, 0x22, 0x22, 0x22, 0x44, 0x88, 0x77, 0x00, 0x88, 0xdd, 0xaa, 0x88, 0x88,
            0x22, 0xcc, 0x00, 0xcc, 0x22, 0x22, 0x22, 0x44, 0x88, 0x77, 0x00, 0x99, 0xaa, 0xaa, 0xaa, 0xee,
            0x22, 0xcc, 0x00, 0x00, 0x00, 0xee, 0x00, 0x00, 0x88, 0x77, 0x00, 0xcc, 0xbb, 0x88, 0x88, 0xcc,
            0x00, 0xcc, 0x22, 0x22, 0xcc, 0x00, 0xcc, 0x22, 0x00, 0x77, 0x88, 0x88, 0x77, 0x00, 0x77, 0x88,
            0xcc, 0x22, 0x22, 0xcc, 0x00, 0x22, 0xee, 0x22, 0x77, 0x88, 0x88, 0x77, 0x00, 0x00, 0xff, 0x44,
            0x66, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xcc, 0x22, 0x22, 0xcc, 0x00, 0x22, 0x22, 0xaa, 0x77, 0x88, 0x88, 0x77, 0x00, 0x66, 0x99, 0x88,
            0x22, 0x44, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88, 0x88, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xcc, 0x22, 0x22, 0xcc, 0x00, 0xcc, 0x22, 0x22, 0x77, 0x88, 0x88, 0x77, 0x00, 0x88, 0xdd, 0xaa,
            0x22, 0x44, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xaa, 0xee, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xcc, 0x22, 0x22, 0xcc, 0x00, 0xcc, 0x22, 0x22, 0x77, 0x88, 0x88, 0x77, 0x00, 0x99, 0xaa, 0xaa,
            0x22, 0xcc, 0x00, 0xcc, 0x22, 0x22, 0xcc, 0x00, 0x88, 0x77, 0x00, 0x77, 0x88, 0x88, 0x77, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x77, 0x88,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xc0, 0x20, 0x90, 0x80, 0x00, 0x00, 0x30, 0x30, 0x10, 0x10, 0x00, 0x00,
            0x41, 0x21, 0x12, 0x03, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x0c, 0x0c, 0x8c, 0x0c, 0x00, 0x00, 0x00, 0x07, 0x0f, 0x0f, 0xc3, 0x1f,
            0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x08, 0x0f, 0x2f, 0x4f, 0x0e, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x07, 0x4f, 0x0f, 0xa7, 0x87, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x10, 0x10,
            0xd3, 0x87, 0x97, 0x0f, 0x2f, 0x07, 0x00, 0x00, 0x33, 0x10, 0x10, 0x10, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x08, 0x00, 0x00, 0x00, 0x08, 0x0e, 0x8e, 0x1f, 0x0f,
            0x0c, 0x08, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4f, 0x1f, 0x0f, 0x4f, 0x0e, 0x08, 0x00, 0x00,
            0x00, 0x00, 0x01, 0x03, 0x87, 0x87, 0x87, 0x47, 0x00, 0x00, 0x00, 0x10, 0x10, 0x30, 0x30, 0x10,
            0xef, 0x47, 0x07, 0x07, 0x03, 0x01, 0x00, 0x00, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x08, 0x0c, 0x0c, 0x0c, 0x00, 0x00, 0x0e, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f,
            0x0c, 0x0c, 0x0c, 0x08, 0x08, 0x00, 0x00, 0x00, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x0e, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x01, 0x0f, 0x0f, 0x0f, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x02,
            0x0f, 0x0b, 0x0c, 0x0f, 0x01, 0x00, 0x00, 0x00, 0x02, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x0c, 0x68, 0x68, 0x68, 0x6e, 0x6e, 0x00, 0x00, 0x03, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f,
            0x68, 0x68, 0x68, 0x68, 0x68, 0x0c, 0x00, 0x00, 0x0f, 0x0f, 0x07, 0x0c, 0x0f, 0x03, 0x00, 0x00,
            0x00, 0x00, 0x07, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x01, 0x20,
            0x87, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x00, 0x00, 0x10, 0x00, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x08, 0x0c, 0x0c, 0x0c, 0x00, 0x00, 0x0c, 0x0f, 0xcf, 0x2f, 0x0f, 0x0f,
            0x08, 0x0c, 0x0c, 0x08, 0x00, 0x00, 0x00, 0x00, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x0c, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x30, 0x52, 0x61, 0xf1, 0xbc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x02, 0x03,
            0xd2, 0x63, 0x52, 0x30, 0x00, 0x00, 0x00, 0x00, 0x02, 0x02, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x80, 0x48, 0x84, 0xc2, 0xe0, 0x00, 0x00, 0xe0, 0xb4, 0x7c, 0xe1, 0x5b, 0xa5,
            0x68, 0x84, 0xc0, 0x80, 0x00, 0x00, 0x00, 0x00, 0xf5, 0xe1, 0x5a, 0xbe, 0xe0, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x0f, 0x33, 0x31, 0x71, 0xf3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf0, 0xf3, 0x71, 0x31, 0x33, 0x0f, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x0c, 0x8e, 0xcf, 0x88,
            0xcc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x88, 0xcf, 0x8e, 0x0c, 0x08, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0xe0, 0xe0, 0xf1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x10, 0x20,
            0xe0, 0xf1, 0xe0, 0xe0, 0x00, 0x00, 0x00, 0x00, 0x20, 0x20, 0x10, 0x10, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88, 0xcc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x88, 0xdd,
            0x22, 0xcc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xef, 0x67, 0x77, 0x33, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x11, 0x23, 0x67, 0x77, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x79, 0x69, 0x0f, 0x1f, 0xff, 0xff, 0x33, 0x00,
            0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x33, 0x79, 0x69, 0x0f, 0x1f, 0xff, 0xff,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0xcc, 0x88, 0x00, 0x88, 0xcc, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0x88, 0x00, 0x88, 0xcc, 0xcc, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xf0, 0xf0, 0xf7, 0x88, 0x00, 0x00, 0x00, 0x00, 0x33, 0x74, 0x74, 0xf8, 0xf9, 0xf9, 0xf9,
            0x00, 0x00, 0x00, 0x88, 0xf7, 0xf0, 0xf0, 0xff, 0xf9, 0xf9, 0xf9, 0xf8, 0x74, 0x74, 0x33, 0x00,
            0xff, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xff,
            0x00, 0xcc, 0xe2, 0xe2, 0xf1, 0xf9, 0xf9, 0xf9, 0xff, 0xf0, 0xf0, 0xfe, 0x11, 0x00, 0x00, 0x00,
            0xf9, 0xf9, 0xf9, 0xf1, 0xe2, 0xe2, 0xcc, 0x00, 0x00, 0x00, 0x00, 0x11, 0xfe, 0xf0, 0xf0, 0xff,
            0xff, 0xf0, 0xf0, 0xf0, 0xf0, 0xf8, 0xf8, 0xf8, 0xff, 0xf0, 0xf0, 0xfe, 0x11, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0xf8, 0xf0, 0xf0, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x11, 0xfe, 0xf0, 0xf0, 0xff,
            0xff, 0xf0, 0xf0, 0xf7, 0x88, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xf0, 0xf0, 0xf1, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x88, 0xf7, 0xf0, 0xf0, 0xff, 0xf1, 0xf1, 0xf1, 0xf0, 0xf0, 0xf0, 0xf0, 0xff,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9,
            0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0xe2, 0xe2, 0xf1, 0xf1, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf1, 0xf1, 0xf1, 0xf1, 0xe2, 0xe2, 0xcc, 0x00,
            0x00, 0x33, 0x74, 0x74, 0xf8, 0xf8, 0xf8, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0xf8, 0xf8, 0x74, 0x74, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x00, 0x33, 0x74, 0xf8, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0x74, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xf0, 0x00, 0x00, 0x00, 0x00, 0xff, 0xf0, 0xf0, 0xf0,
            0xf0, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x00, 0xf0, 0xf0, 0xf0, 0xff, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0xe2, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf1, 0xf1, 0xe2, 0xcc, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xff, 0xf8, 0xf8, 0xf9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf9, 0xf8, 0xf8, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0xf1, 0xf1, 0xf9,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf9, 0xf1, 0xf1, 0xff, 0x00, 0x00, 0x00, 0x00,
            0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x88, 0xf7, 0xf0, 0xf0, 0xf0, 0xf1, 0xf1, 0xf1, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0,
            0xf0, 0xf0, 0xf0, 0xf7, 0x88, 0x00, 0x00, 0x00, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf1, 0xf1, 0xf1,
            0xf8, 0xf8, 0xf8, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0x00, 0x00, 0x00, 0x11, 0xfe, 0xf0, 0xf0, 0xf0,
            0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf8, 0xf8, 0xf8, 0xf0, 0xf0, 0xf0, 0xfe, 0x11, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x33, 0x74, 0xf8, 0xf8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xf8, 0xf8, 0x74, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xcc, 0xe2, 0xf1, 0xf1,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xf1, 0xf1, 0xe2, 0xcc, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x88, 0xf7, 0xf0, 0xf0, 0xf0, 0xf9, 0xf9, 0xf9, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8,
            0xf0, 0xf0, 0xf0, 0xf7, 0x88, 0x00, 0x00, 0x00, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf9, 0xf9, 0xf9,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        };
    }
}
