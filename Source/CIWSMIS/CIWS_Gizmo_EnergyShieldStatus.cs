using RimWorld;
using UnityEngine;
using Verse;

namespace CIWSMIS;

[StaticConstructorOnStartup]
public class CIWS_Gizmo_EnergyShieldStatus : Gizmo_EnergyShieldStatus
{
    private static readonly Texture2D FullShieldBarTex =
        SolidColorMaterials.NewSolidColorTexture(new Color(0.2f, 0.2f, 0.24f));

    private static readonly Texture2D EmptyShieldBarTex = SolidColorMaterials.NewSolidColorTexture(Color.clear);
    public new CIWSShieldBelt shield;

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
            Widgets.Label(rect2, shield.LabelCap);
            var rect3 = rect;
            rect3.yMin = overRect.height / 2f;
            var fillPercent = shield.Energy / Mathf.Max(1f, shield.GetStatValue(StatDefOf.EnergyShieldEnergyMax));
            Widgets.FillableBar(rect3, fillPercent, FullShieldBarTex, EmptyShieldBarTex, false);
            Text.Font = GameFont.Small;
            Text.Anchor = TextAnchor.MiddleCenter;
            Widgets.Label(rect3,
                $"{shield.Energy * 100f:F0} / {shield.GetStatValue(StatDefOf.EnergyShieldEnergyMax) * 100f:F0}");
            Text.Anchor = TextAnchor.UpperLeft;
        });
        return new GizmoResult(GizmoState.Clear);
    }
}