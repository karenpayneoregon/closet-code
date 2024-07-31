#nullable disable
using ProtoBuf;

namespace IncrementSequenceDemos.Models;

[ProtoContract]
public class Invoice
{
    [ProtoMember(1)]
    public int Id { get; set; }
    [ProtoMember(2)]
    public string Number { get; set; }
}