
using Modbus.Device;
using System.Net.Sockets;
using System;
using System.Windows.Forms;

namespace TemperatureDataLogger.Business
{
    public static class IhmBLL
    {
        private static IModbusMaster ModbusMaster { get; set; }

        private static readonly int ModbusPort = 502;

        public static string GetModbusTcpData()
        {
            if (ModbusMaster == null)
                throw new InvalidOperationException("A instancia de Modbus não foi iniciada");

            ushort[] dados = ModbusMaster.ReadHoldingRegisters(1, 0, 1);

            string modBusValue = dados[0].ToString();

            return modBusValue;
        }

        public static bool MayTriggersTheOutput(string ModBusValue, string MaximaTemperature, string MinimaTemperature)
        {
            double tempValue = double.Parse(ModBusValue);

            double.TryParse(MaximaTemperature, out double max);
            double.TryParse(MinimaTemperature, out double min);

            var isntNullTxtValue = !string.IsNullOrEmpty(MaximaTemperature) && !string.IsNullOrEmpty(MinimaTemperature);

            var isMinOrMax = tempValue < min || tempValue > max;
            var canTriggersTheOutput = isntNullTxtValue && isMinOrMax;

            return canTriggersTheOutput;
        }

        public static void TriggersTheOutput(bool CanTriggersOutput)
        {
            if (ModbusMaster is null)
                throw new InvalidOperationException("A instancia de Modbus não foi iniciada");

            if (CanTriggersOutput)
            {
                ModbusMaster.WriteSingleRegister(
                            1, // slave id (esp geralmente = 1)
                            1, // endereço do registrador (reg_cmd)
                            1  // valor a escrever
                            );
            }

            else
            {
                ModbusMaster.WriteSingleRegister(
                          1, // slave id (esp geralmente = 1)
                          1, // endereço do registrador (reg_cmd)
                          0  // valor a escrever
                          );
            }
        }

        public static IModbusMaster ConfigureTCPIpConnection(string ipConnection)
        {
            try
            {
                var client = CreateTCPClientFactory();

                client.Connect(ipConnection, ModbusPort);

                ModbusMaster = ModbusIpMaster.CreateIp(client);

                return ModbusMaster;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar: {ex.Message}");
                return null;
            }

            TcpClient CreateTCPClientFactory()
            {
                return new TcpClient();
            }
        }

        public static void SaveChangeOfTemperature(double maxTemperatureSet, double minTemperatureSet, double sensorValue)
        {
            DataBaseQueries.InsertDatabaseInfo(DateTime.Now, sensorValue, maxTemperatureSet, minTemperatureSet);
        }
    }
}
