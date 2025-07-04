using RimWorld;
using UnityEngine;
using Verse;

namespace CIWSMIS;

[StaticConstructorOnStartup]
public class CIWS_Gizmo_EnergyShieldStatus : Gizmo_EnergyShieldStatus
{
    private static readonly Texture2D fullShieldBarTex =
        SolidColorMaterials.NewSolidColorTexture(new Color(0.2f, 0.2f, 0.24f));

    private static readonly Texture2D emptyShieldBarTex = SolidColorMaterials.NewSolidColorTexture(Color.clear);
    public CIWSShieldBelt Shield;

    public CIWS_Gizmo_EnergyShieldStatus()
    {
        base.Order = -100f;
    }

    public override float GetWidth(float maxWidth)
    {
        return 140f;
    }

    public override GizmoResult GizmoOnGUI(Vector2 topLeft, float maxWidth, GizmoRenderParms parms)
    {
        var overRect = new Rect(topLeft.x, topLeft.y, GetWidth(maxWidth), 75f);
        Find.WindowStack.ImmediateWindow(324265, overRect, WindowLayer.GameUI, delegate
        {
            var rect = overRect.AtZero().ContractedBy(6f);
            var rect2 = rect;
            rect2.height = overRect.height / 2f;
            Text.Font = GameFont.Tiny;
            Widgets.Label(rect2, Shield.LabelCap);
            var rect3 = rect;
            rect3.yMin = overRect.height / 2f;
            var fillPercent = Shield.Energy / Mathf.Max(1f, Shield.GetStatValue(StatDefOf.EnergyShieldEnergyMax));
            Widgets.FillableBar(rect3, fillPercent, fullShieldBarTex, emptyShieldBarTex, false);
            Text.Font = GameFont.Small;
            Text.Anchor = TextAnchor.MiddleCenter;
            Widgets.Label(rect3,
                $"{Shield.Energy * 100f:F0} / {Shield.GetStatValue(StatDefOf.EnergyShieldEnergyMax) * 100f:F0}");
            Text.Anchor = TextAnchor.UpperLeft;
        });
        return new GizmoResult(GizmoState.Clear);
    }
}