using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTest;

public static class StringReplace
{
    public static void ESMEVariantMappingSB(Message_SR_12_2_ESME message)
    {
        var sb = new StringBuilder(message.ESMEVariant);

        sb
            .Replace(ESMEVariantDuis.A, ESMEVariantAutomation.A)
            .Replace(ESMEVariantDuis.B, ESMEVariantAutomation.B)
            .Replace(ESMEVariantDuis.C, ESMEVariantAutomation.C)
            .Replace(ESMEVariantDuis.AD, ESMEVariantAutomation.AD)
            .Replace(ESMEVariantDuis.BD, ESMEVariantAutomation.BD)
            .Replace(ESMEVariantDuis.CD, ESMEVariantAutomation.CD)
            .Replace(ESMEVariantDuis.ADE, ESMEVariantAutomation.ADE)
            .Replace(ESMEVariantDuis.BDE, ESMEVariantAutomation.BDE)
            .Replace(ESMEVariantDuis.CDE, ESMEVariantAutomation.CDE);

        message.ESMEVariant = sb.ToString();
    }

    public static void ESMEVariantMappingSB(Message_SR_12_2_ESME message, StringBuilder sb)
    {
        sb.Append(message.ESMEVariant);
        sb
            .Replace(ESMEVariantDuis.A, ESMEVariantAutomation.A)
            .Replace(ESMEVariantDuis.B, ESMEVariantAutomation.B)
            .Replace(ESMEVariantDuis.C, ESMEVariantAutomation.C)
            .Replace(ESMEVariantDuis.AD, ESMEVariantAutomation.AD)
            .Replace(ESMEVariantDuis.BD, ESMEVariantAutomation.BD)
            .Replace(ESMEVariantDuis.CD, ESMEVariantAutomation.CD)
            .Replace(ESMEVariantDuis.ADE, ESMEVariantAutomation.ADE)
            .Replace(ESMEVariantDuis.BDE, ESMEVariantAutomation.BDE)
            .Replace(ESMEVariantDuis.CDE, ESMEVariantAutomation.CDE);

        message.ESMEVariant = sb.ToString();
    }

    public static void ESMEVariantMappingSwitchCase(Message_SR_12_2_ESME message)
    {
        switch (message.ESMEVariant)
        {
            case ESMEVariantDuis.A:
                message.ESMEVariant = ESMEVariantAutomation.A;
                break;
            case ESMEVariantDuis.B:
                message.ESMEVariant = ESMEVariantAutomation.B;
                break;
            case ESMEVariantDuis.C:
                message.ESMEVariant = ESMEVariantAutomation.C;
                break;
            case ESMEVariantDuis.AD:
                message.ESMEVariant = ESMEVariantAutomation.AD;
                break;
            case ESMEVariantDuis.BD:
                message.ESMEVariant = ESMEVariantAutomation.BD;
                break;
            case ESMEVariantDuis.CD:
                message.ESMEVariant = ESMEVariantAutomation.CD;
                break;
            case ESMEVariantDuis.ADE:
                message.ESMEVariant = ESMEVariantAutomation.ADE;
                break;
            case ESMEVariantDuis.BDE:
                message.ESMEVariant = ESMEVariantAutomation.BDE;
                break;
            case ESMEVariantDuis.CDE:
                message.ESMEVariant = ESMEVariantAutomation.CDE;
                break;
            default:
                break;
        }
    }

    public static void ESMEVariantMappingReplace(Message_SR_12_2_ESME message)
    {
        message.ESMEVariant = message.ESMEVariant!
            .Replace(ESMEVariantDuis.A, ESMEVariantAutomation.A)
            .Replace(ESMEVariantDuis.B, ESMEVariantAutomation.B)
            .Replace(ESMEVariantDuis.C, ESMEVariantAutomation.C)
            .Replace(ESMEVariantDuis.AD, ESMEVariantAutomation.AD)
            .Replace(ESMEVariantDuis.BD, ESMEVariantAutomation.BD)
            .Replace(ESMEVariantDuis.CD, ESMEVariantAutomation.CD)
            .Replace(ESMEVariantDuis.ADE, ESMEVariantAutomation.ADE)
            .Replace(ESMEVariantDuis.BDE, ESMEVariantAutomation.BDE)
            .Replace(ESMEVariantDuis.CDE, ESMEVariantAutomation.CDE);
    }
}
