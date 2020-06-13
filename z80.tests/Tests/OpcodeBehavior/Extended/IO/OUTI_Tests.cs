using Xunit;

namespace JustinCredible.ZilogZ80.Tests
{
    public class OUTI_Tests : BaseTest
    {
        [Fact]
        public void Test_OUTI()
        {
            var rom = AssembleSource($@"
                org 00h
                OUTI
                HALT
            ");

            var memory = new byte[16*1024];
            memory[0x1234] = 77;

            var initialState = new CPUConfig()
            {
                Registers = new CPURegisters()
                {
                    B = 32,
                    C = 44,
                    HL = 0x1234,
                },
                Flags = new ConditionFlags()
                {
                    // Should remain unaffected.
                    Sign = true,
                    HalfCarry = true,
                    ParityOverflow = true,
                    Carry = true,
                },
                MemorySize = memory.Length,
            };

            var cpu = new CPU(initialState);

            byte actualData = 0;
            var actualDeviceID = -1;

            cpu.OnDeviceWrite += (int deviceID, byte data) => {
                actualDeviceID = deviceID;
                actualData = data;
            };

            var state = Execute(rom, memory, cpu);

            Assert.Equal(77, actualData);
            Assert.Equal(44, actualDeviceID);

            Assert.Equal(31, state.Registers.B);
            Assert.Equal(44, state.Registers.C);
            Assert.Equal(0x1235, state.Registers.HL);
            Assert.Equal(77, state.Memory[0x1234]);

            // Should remain unaffected.
            Assert.True(state.Flags.Sign);
            Assert.True(state.Flags.HalfCarry);
            Assert.True(state.Flags.ParityOverflow);
            Assert.True(state.Flags.Carry);

            Assert.False(state.Flags.Zero);
            Assert.True(state.Flags.Subtract);

            Assert.Equal(2, state.Iterations);
            Assert.Equal(4 + 16, state.Cycles);
            Assert.Equal(0x02, state.Registers.PC);
        }

        [Fact]
        public void Test_OUTI_SetsZeroFlag()
        {
            var rom = AssembleSource($@"
                org 00h
                OUTI
                HALT
            ");

            var memory = new byte[16*1024];
            memory[0x1234] = 77;

            var initialState = new CPUConfig()
            {
                Registers = new CPURegisters()
                {
                    B = 1,
                    C = 44,
                    HL = 0x1234,
                },
                Flags = new ConditionFlags()
                {
                    // Should remain unaffected.
                    Sign = true,
                    HalfCarry = true,
                    ParityOverflow = true,
                    Carry = true,

                    // Should get set.
                    Zero = false,
                },
                MemorySize = memory.Length,
            };

            var cpu = new CPU(initialState);

            byte actualData = 0;
            var actualDeviceID = -1;

            cpu.OnDeviceWrite += (int deviceID, byte data) => {
                actualDeviceID = deviceID;
                actualData = data;
            };

            var state = Execute(rom, memory, cpu);

            Assert.Equal(77, actualData);
            Assert.Equal(44, actualDeviceID);

            Assert.Equal(0, state.Registers.B);
            Assert.Equal(44, state.Registers.C);
            Assert.Equal(0x1235, state.Registers.HL);
            Assert.Equal(77, state.Memory[0x1234]);

            // Should remain unaffected.
            Assert.True(state.Flags.Sign);
            Assert.True(state.Flags.HalfCarry);
            Assert.True(state.Flags.ParityOverflow);
            Assert.True(state.Flags.Carry);

            // Should get set.
            Assert.True(state.Flags.Zero);
            Assert.True(state.Flags.Subtract);

            Assert.Equal(2, state.Iterations);
            Assert.Equal(4 + 16, state.Cycles);
            Assert.Equal(0x02, state.Registers.PC);
        }
    }
}
