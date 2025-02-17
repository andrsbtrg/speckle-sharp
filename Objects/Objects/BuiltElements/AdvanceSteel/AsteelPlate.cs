using System.Collections.Generic;
using Objects.Geometry;
using Objects.Structural.Materials;
using Objects.Structural.Properties.Profiles;
using Speckle.Core.Kits;
using Speckle.Core.Models;

namespace Objects.BuiltElements.AdvanceSteel;

public class AsteelPlate : Area, IDisplayValue<List<Mesh>>, IHasArea, IHasVolume, IAsteelObject
{
  [SchemaInfo("AsteelPlate", "Creates a Advance Steel plate.", "Advance Steel", "Structure")]
  public AsteelPlate(SectionProfile profile, Polyline outline, string units, StructuralMaterial material = null)
  {
    this.outline = outline;
    this.material = material;
    this.units = units;
  }

  public AsteelPlate() { }

  [SchemaInfo("AsteelPlate", "Creates a Advance Steel plate.", "Advance Steel", "Structure")]
  public AsteelPlate(Polyline outline, string units, StructuralMaterial material = null)
  {
    this.outline = outline;
    this.material = material;
    this.units = units;
  }

  [DetachProperty]
  public StructuralMaterial material { get; set; }

  public Base userAttributes { get; set; }
}
