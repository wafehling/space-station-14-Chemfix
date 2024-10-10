﻿using Content.Shared.Dataset;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Dictionary;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Set;

namespace Content.Shared.Impstation.Spelfs;

[Virtual, DataDefinition]
[Serializable, NetSerializable]
public partial class SpelfMood
{
    [DataField(readOnly: true), ViewVariables(VVAccess.ReadOnly)]
    public ProtoId<SpelfMoodPrototype> ProtoId = string.Empty;

    /// <summary>
    /// A locale string of the mood name.
    /// </summary>
    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public string MoodName = string.Empty;

    /// <summary>
    /// A locale string of the mood description. Gets passed to
    /// <see cref="Loc.GetString"/> with <see cref="MoodVars"/>.
    /// </summary>
    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public string MoodDesc = string.Empty;

    [DataField(serverOnly: true, customTypeSerializer: typeof(PrototypeIdHashSetSerializer<SpelfMoodPrototype>))]
    [ViewVariables(VVAccess.ReadWrite)]
    public HashSet<string> Conflicts = new();

    /// <summary>
    /// Additional localized words for the <see cref="MoodDesc"/>, for things like random
    /// verbs and nouns.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public Dictionary<string, string> MoodVars = new();
}

[Prototype("spelfMood")]
[Serializable, NetSerializable]
public sealed partial class SpelfMoodPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public string MoodName = string.Empty;

    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public string MoodDesc = string.Empty;

    /// <summary>
    /// A list of mood IDs that this mood will conflict with.
    /// </summary>
    [DataField("conflicts", customTypeSerializer: typeof(PrototypeIdHashSetSerializer<SpelfMoodPrototype>))]
    public HashSet<string> Conflicts = new();

    /// <summary>
    /// Extra mood variables that will be randomly chosen and provided
    /// to the <see cref="Loc.GetString"/> call on <see cref="SpelfMood.MoodDesc"/>.
    /// </summary>
    [DataField("moodVars", customTypeSerializer: typeof(PrototypeIdValueDictionarySerializer<string, DatasetPrototype>))]
    public Dictionary<string, string> MoodVarDatasets = new();
}
