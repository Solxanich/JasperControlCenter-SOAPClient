﻿using SoapClient.com.jasperwireless.api7;
using System;

namespace SoapClient.ControlCenterWrappers
{
    internal static class PeakJasperRapper
    {
        internal static void SetNewIP(TerminalService service, string licenseKey, string iccId, string ip, string pdpId, string apn)
        {
            AssignOrUpdateIPAddressRequest request = new AssignOrUpdateIPAddressRequest()
            {
                licenseKey = licenseKey,
                version = "1.0",
                messageId = ip,
                iccid = iccId,
                pdpId = pdpId,
                apn = apn,
                ipAddress = ip
            };

            try
            {
                AssignOrUpdateIPAddressResponse response = service.AssignOrUpdateIPAddress(request);
                Console.WriteLine($"New IP for {iccId} is: {response.correlationId}");
            }
            catch (System.Web.Services.Protocols.SoapException e)
            {
                Shared.LogException(e);
            }
        }
    }
}
