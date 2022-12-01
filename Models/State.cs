using System;

namespace Server.Data.Models;

public enum State
{
    Undefined,
    OK,
    UseViolation,
    Lost,
    PutAway
}
