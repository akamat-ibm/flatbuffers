// automatically generated, do not modify

namespace NamespaceA.NamespaceB
{

using System;
using FlatBuffers;

public sealed class StructInNestedNS : Struct {
  public StructInNestedNS __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int A { get { return bb.GetInt(bb_pos + 0); } }
  public void MutateA(int a) { bb.PutInt(bb_pos + 0, a); }
  public int B { get { return bb.GetInt(bb_pos + 4); } }
  public void MutateB(int b) { bb.PutInt(bb_pos + 4, b); }

  public static Offset<StructInNestedNS> CreateStructInNestedNS(FlatBufferBuilder builder, int A, int B) {
    builder.Prep(4, 8);
    builder.PutInt(B);
    builder.PutInt(A);
    return new Offset<StructInNestedNS>(builder.Offset);
  }
};


}
