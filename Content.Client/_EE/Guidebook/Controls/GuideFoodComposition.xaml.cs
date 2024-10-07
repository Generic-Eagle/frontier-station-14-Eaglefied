using Content.Client.Guidebook.Controls;
using Content.Client.UserInterface.ControlExtensions;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;
using JetBrains.Annotations;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._EE.Guidebook.Controls; // Frontier: add _EE

[UsedImplicitly, GenerateTypedNameReferences]
public sealed partial class GuideFoodComposition : BoxContainer, ISearchableControl
{
    public GuideFoodComposition(ReagentPrototype proto, FixedPoint2 quantity)
    {
        RobustXamlLoader.Load(this);

        ReagentLabel.Text = proto.LocalizedName;
        AmountLabel.Text = quantity.ToString();
    }

    public bool CheckMatchesSearch(string query)
    {
        return this.ChildrenContainText(query);
    }

    public void SetHiddenState(bool state, string query)
    {
        Visible = CheckMatchesSearch(query) ? state : !state;
    }
}
