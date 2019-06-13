SELECT [Product].[Name], [Category].[Name]
  FROM [Product]
  LEFT JOIN [Relation] ON [Product].[ProductID] = [Relation].[ProductID]
  LEFT JOIN [Category] ON [Relation].[CategoryID] = [Category].[CategoryID];