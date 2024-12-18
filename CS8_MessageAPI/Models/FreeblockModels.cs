namespace CS8_MessageAPI.Models;
public record Block(    
    string blockId,
    string name,
    string schoolLevel);
    
public record FreeBlock(
    Block block,
    DateTime start,
    DateTime end);

public record FreeBlockCollection(
    FreeBlock[]freeBlocks,
    DateOnly[]inRange);