# Star-Trek-Nav
# Calculating Star Trek distances, and add a warp factor giving a time
# 
# Book reference: 15 02 076 12
# 
### Explanation
# Grid 15
# 1 - being a 10 degree wedge out of the 360 degree circle with centre in galaxy centre. Noted as 0-9 and a-z (10 + 26 = 36)
# 5 - being the 5th band, out of 10. A band being 5000 LY wide, 3600 LY thickness.
# 
# Quad 02 - being a 3D reference of 100 Quads in a 5000 x 3600 x 10 degree (~4500) LY.
# 
# Block 076 - Dividing that Quad again, results in a 1000 Blocks, out of a 1000 x 800 x 2 degree (~ 900) LY
# 
# Sector 12 - This Block is again divided up into a 100 Sectors. 100 x 80 x ~100 LY (0 deg 13' 20"). 
# 
# Putting you within an average of ~40-50 LY distance of your target. A sector could potentially contain several systems. Example both sol system and Alpha Centauri system within the same sector.
# 
# *---*
### Using Euclidean distance formula calculating distances between two points in 3D space, [x1, y1, z1] and [x2, y2, z2]
# 
# delta Δx = x2 - x1
# delta Δy = y2 - y1
# delta Δz = z2 - z1
# 
# distance = sqr ([Δx]^2 + [Δy]^2 + [Δz]^2) 
# 
# Adding Warp factor calculations after we know the distance.
# --
# Custom factor
# --
# Warp 5
# Warp 7
# Warp 9
# Warp 9.2
# Warp 9.5
# Warp 9.9
# Warp 9.999
# --
# 
# *---*
# 
### Version
# 0.1 - Basic interface
# 0.2 - Basic Euclidean Math
# 0.3 - Basic Warp Factor
# 0.4 - Basic Pre-coded locations
# 0.5 - XML saved locations / DB
# 0.6 - Add/Load entries to XML
# 0.7 - Save last known location
# 0.8 - LCARS UI design

# 1.? - Release build

*---*