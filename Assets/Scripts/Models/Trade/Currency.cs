﻿#region License
// ====================================================
// Project Porcupine Copyright(C) 2016 Team Porcupine
// This program comes with ABSOLUTELY NO WARRANTY; This is free software, 
// and you are welcome to redistribute it under certain conditions; See 
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using Newtonsoft.Json.Linq;

public class Currency : IPrototypable
{
    public float Balance = 0f;

    /// <summary>
    /// Initializes a new instance of the <see cref="Currency"/> class.
    /// Empty constructor to implement IPrototypable, should not be used.
    /// </summary>
    public Currency()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Currency"/> class.
    /// Copy constructor. Use Clone instead.
    /// </summary>
    /// <param name="other">The currency to copy.</param>
    public Currency(Currency other)
    {
        Name = other.Name;
        ShortName = other.ShortName;
    }

    /// <summary>
    /// Gets the currency name.
    /// </summary>
    /// <value>The currency name.</value>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the currency short name.
    /// </summary>
    /// <value>The currency short name.</value>
    public string ShortName { get; private set; }

    /// <summary>
    /// Gets the currency type. Used for the prototype map and is equal to the name.
    /// </summary>
    /// <value>The currency type/name.</value>
    public string Type
    {
        get { return Name; }
    }

    /// <summary>
    /// Clone this instance.
    /// </summary>
    public Currency Clone()
    {
        return new Currency(this);
    }

    /// <summary>
    /// Reads the prototype from the specified JProperty.
    /// </summary>
    /// <param name="jsonProto">The JProperty containing the prototype.</param>
    public void ReadJsonPrototype(JProperty jsonProto)
    {
        Name = jsonProto.Name;
        JToken innerJson = jsonProto.Value;
        ShortName = (string)innerJson["ShortName"];
    }
}
